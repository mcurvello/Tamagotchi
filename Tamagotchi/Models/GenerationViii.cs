using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class GenerationViii
	{
        [JsonPropertyName("icons")]
        public DreamWorld Icons { get; set; }
    }
}
