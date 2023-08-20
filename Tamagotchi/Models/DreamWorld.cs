﻿using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class DreamWorld
	{
        [JsonPropertyName("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }
    }
}
