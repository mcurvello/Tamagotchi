using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class Stat
	{
        [JsonPropertyName("base_stat")]
        public long BaseStat { get; set; }

        [JsonPropertyName("effort")]
        public long Effort { get; set; }

        [JsonPropertyName("stat")]
        public Species StatStat { get; set; }
    }
}
