using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class VersionDetail
	{
        [JsonPropertyName("rarity")]
        public long Rarity { get; set; }

        [JsonPropertyName("version")]
        public Species Version { get; set; }
    }
}
