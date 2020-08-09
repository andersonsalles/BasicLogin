using Newtonsoft.Json;

namespace BasicLogin.Dtos
{
    public class GenderDto
    {
        [JsonProperty("id", Required = Required.Always)]
        public int Id { get; set; }
    }
}