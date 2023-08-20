﻿using Newtonsoft.Json;

namespace Tamagotchi.Models
{
    public class GameIndex
    {
        [JsonProperty("game_index")]
        public long GameIndexGameIndex { get; set; }

        [JsonProperty("version")]
        public Species Version { get; set; }
    }
}
