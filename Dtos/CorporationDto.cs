using Newtonsoft.Json;

namespace BasicLogin.Dtos
{
    public class CorporationDto
    {
        [JsonProperty("cnpj", Required = Required.Always)]
        public string Cnpj { get; set; }

        [JsonProperty("ie", NullValueHandling = NullValueHandling.Ignore)]
        public string Ie { get; set; }

        [JsonProperty("razaoSocial", NullValueHandling = NullValueHandling.Ignore)]
        public string RazaoSocial { get; set; }
    }
}