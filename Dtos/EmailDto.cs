using Newtonsoft.Json;

namespace BasicLogin.Dtos
{
    public class EmailDto
    {
        [JsonProperty("emailAddress", Required = Required.Always)]
        public string EmailAddress { get; set; }
    }
}