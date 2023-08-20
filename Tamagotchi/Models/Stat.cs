using Newtonsoft.Json;

namespace Tamagotchi.Models
{
    public class Stat
	{
        [JsonProperty("base_stat")]
        public long BaseStat { get; set; }

        [JsonProperty("effort")]
        public long Effort { get; set; }

        [JsonProperty("stat")]
        public Species StatStat { get; set; }
    }
}
