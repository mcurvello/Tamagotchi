using Newtonsoft.Json;

namespace Tamagotchi.Models
{
    public class DreamWorld
	{
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }
    }
}
