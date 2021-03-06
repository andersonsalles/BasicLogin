﻿using Newtonsoft.Json;

namespace BasicLogin.Dtos
{
    public class AddressDto
    {
        [JsonProperty("mainAddress", Required = Required.Always)]
        public string MainAddress { get; set; }

        [JsonProperty("stateId", Required = Required.Always)]
        public int StateId { get; set; }

        [JsonProperty("cityId", Required = Required.Always)]
        public int CityId { get; set; }

        [JsonProperty("neighborhood", Required = Required.Always)]
        public string Neighborhood { get; set; }
    }
}