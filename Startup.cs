using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BasicLogin.Data;
using BasicLogin.Data.Dtos;
using BasicLogin.Data.Implementation;
using BasicLogin.Data.Interfaces;
using BasicLogin.Dtos;
using BasicLogin.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace BasicLogin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII
                            .GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PersonDto, Person>();
                cfg.CreateMap<Person, PersonDto>();

                cfg.CreateMap<AddressDto, Address>();
                cfg.CreateMap<Address, AddressDto>();

                cfg.CreateMap<CorporationDto, Corporation>();
                cfg.CreateMap<Corporation, CorporationDto>();

                cfg.CreateMap<EmailDto, Email>();
                cfg.CreateMap<Email, EmailDto>();

                cfg.CreateMap<GenderDto, Gender>();
                cfg.CreateMap<Gender, GenderDto>();

                cfg.CreateMap<PersonalDto, Personal>();
                cfg.CreateMap<Personal, PersonalDto>();

                cfg.CreateMap<PhoneDto, Phone>();
                cfg.CreateMap<Phone, PhoneDto>();
            });
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
