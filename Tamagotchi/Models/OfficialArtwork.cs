using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class OfficialArtwork
	{
        [JsonPropertyName("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonPropertyName("front_shiny")]
        public Uri FrontShiny { get; set; }
    }
}
