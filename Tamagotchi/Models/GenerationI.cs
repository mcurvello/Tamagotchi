using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class GenerationI
	{
        [JsonPropertyName("red-blue")]
        public RedBlue RedBlue { get; set; }

        [JsonPropertyName("yellow")]
        public RedBlue Yellow { get; set; }
    }
}
