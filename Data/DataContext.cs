using BasicLogin.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicLogin.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> Emails { get; set;}
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Corporation> Corporations { get; set; }
        public DbSet<Personal> Personals { get; set; }

    }
}
