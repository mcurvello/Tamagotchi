using Newtonsoft.Json;

namespace Tamagotchi.Models
{
    public class GenerationV
	{
        [JsonProperty("black-white")]
        public Sprites BlackWhite { get; set; }
    }
}
