using Newtonsoft.Json;

namespace Tamagotchi.Models
{
	public class Species
	{
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
