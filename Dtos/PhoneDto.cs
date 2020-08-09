using Newtonsoft.Json;

namespace BasicLogin.Dtos
{
    public class PhoneDto
    {
        [JsonProperty("phoneNumber", Required = Required.Always)]
        public string PhoneNumber { get; set; }
    }
}