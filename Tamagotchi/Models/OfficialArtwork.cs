using Newtonsoft.Json;

namespace Tamagotchi.Models
{
    public class OfficialArtwork
	{
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }
    }
}
