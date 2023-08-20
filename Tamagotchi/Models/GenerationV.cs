using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class GenerationV
	{
        [JsonPropertyName("black-white")]
        public Sprites BlackWhite { get; set; }
    }
}
