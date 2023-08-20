using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class HeldItem
	{
        [JsonPropertyName("item")]
        public Species Item { get; set; }

        [JsonPropertyName("version_details")]
        public VersionDetail[] VersionDetails { get; set; }
    }
}
