using Newtonsoft.Json;

namespace Tamagotchi.Models
{
    public class HeldItem
	{
        [JsonProperty("item")]
        public Species Item { get; set; }

        [JsonProperty("version_details")]
        public VersionDetail[] VersionDetails { get; set; }
    }
}
