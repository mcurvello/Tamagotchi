﻿using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class Sprites
	{
        [JsonPropertyName("back_default")]
        public Uri BackDefault { get; set; }

        [JsonPropertyName("back_female")]
        public object BackFemale { get; set; }

        [JsonPropertyName("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonPropertyName("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object FrontShinyFemale { get; set; }

        [JsonPropertyName("other")]
        public Other Other { get; set; }

        [JsonPropertyName("versions")]
        public Versions Versions { get; set; }

        [JsonPropertyName("animated")]
        public Sprites Animated { get; set; }
    }
}
