using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class GenerationIi
	{
        [JsonPropertyName("crystal")]
        public Crystal Crystal { get; set; }

        [JsonPropertyName("gold")]
        public Gold Gold { get; set; }

        [JsonPropertyName("silver")]
        public Gold Silver { get; set; }
    }
}
