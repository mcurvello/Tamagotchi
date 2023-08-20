using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
	public class Species
	{
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}
