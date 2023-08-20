using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class GenerationIii
	{
        [JsonPropertyName("emerald")]
        public OfficialArtwork Emerald { get; set; }

        [JsonPropertyName("firered-leafgreen")]
        public Gold FireredLeafgreen { get; set; }

        [JsonPropertyName("ruby-sapphire")]
        public Gold RubySapphire { get; set; }
    }
}
