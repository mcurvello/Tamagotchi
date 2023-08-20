using Newtonsoft.Json;

namespace Tamagotchi.Models
{
    public class TypeElement
	{
        [JsonProperty("slot")]
        public long Slot { get; set; }

        [JsonProperty("type")]
        public Species Type { get; set; }
    }
}
