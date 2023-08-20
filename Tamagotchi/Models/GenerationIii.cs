﻿using Newtonsoft.Json;

namespace Tamagotchi.Models
{
    public class GenerationIii
	{
        [JsonProperty("emerald")]
        public OfficialArtwork Emerald { get; set; }

        [JsonProperty("firered-leafgreen")]
        public Gold FireredLeafgreen { get; set; }

        [JsonProperty("ruby-sapphire")]
        public Gold RubySapphire { get; set; }
    }
}
