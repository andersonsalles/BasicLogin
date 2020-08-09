using Newtonsoft.Json;
using System;

namespace BasicLogin.Dtos
{
    public class PersonalDto
    {
        [JsonProperty("cpf", Required = Required.Always)]
        public string Cpf { get; set; }

        [JsonProperty("rg", NullValueHandling = NullValueHandling.Ignore)]
        public string Rg { get; set; }

        [JsonProperty("birthDate", Required = Required.Always)]
        public DateTime BirthDate { get; set; }

        [JsonProperty("genderId", Required = Required.Always)]
        public int GenderId { get; set; }
    }
}