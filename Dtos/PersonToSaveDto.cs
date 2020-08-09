using BasicLogin.Data.Dtos;
using Newtonsoft.Json;

namespace BasicLogin.Dtos
{
    public class PersonToSaveDto
    {
        [JsonProperty("person", Required = Required.Always)]
        public PersonDto PersonDto { get; set; }

        [JsonProperty("address", Required = Required.Always)]
        public AddressDto AddressDto { get; set; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public PhoneDto PhoneDto { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public EmailDto EmailDto { get; set; }

        [JsonProperty("personal", NullValueHandling = NullValueHandling.Ignore)]
        public PersonalDto PersonalDto { get; set; }

        [JsonProperty("corporation", NullValueHandling = NullValueHandling.Ignore)]
        public CorporationDto CorporationDto { get; set; }
    }
}
