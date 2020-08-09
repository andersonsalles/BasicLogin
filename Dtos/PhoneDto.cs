using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BasicLogin.Dtos
{
    public class PhoneDto
    {
        [JsonProperty("phoneNumber", Required = Required.Always)]
        public string PhoneNumber { get; set; }
    }
}
