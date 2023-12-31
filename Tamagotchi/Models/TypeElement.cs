﻿using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class TypeElement
	{
        [JsonPropertyName("slot")]
        public long Slot { get; set; }

        [JsonPropertyName("type")]
        public Species Type { get; set; }
    }
}
