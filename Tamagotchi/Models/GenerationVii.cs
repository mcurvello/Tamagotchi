using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class GenerationVii
	{
        [JsonPropertyName("icons")]
        public DreamWorld Icons { get; set; }

        [JsonPropertyName("ultra-sun-ultra-moon")]
        public Home UltraSunUltraMoon { get; set; }
    }
}
