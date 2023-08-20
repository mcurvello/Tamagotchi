using Newtonsoft.Json;

namespace Tamagotchi.Models
{
    public class GenerationVii
	{
        [JsonProperty("icons")]
        public DreamWorld Icons { get; set; }

        [JsonProperty("ultra-sun-ultra-moon")]
        public Home UltraSunUltraMoon { get; set; }
    }
}
