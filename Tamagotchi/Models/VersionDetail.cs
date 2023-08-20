using Newtonsoft.Json;

namespace Tamagotchi.Models
{
    public class VersionDetail
	{
        [JsonProperty("rarity")]
        public long Rarity { get; set; }

        [JsonProperty("version")]
        public Species Version { get; set; }
    }
}
