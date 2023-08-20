﻿using Newtonsoft.Json;

namespace Tamagotchi.Models
{
    public class GenerationIi
	{
        [JsonProperty("crystal")]
        public Crystal Crystal { get; set; }

        [JsonProperty("gold")]
        public Gold Gold { get; set; }

        [JsonProperty("silver")]
        public Gold Silver { get; set; }
    }
}
