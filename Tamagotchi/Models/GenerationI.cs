using Newtonsoft.Json;

namespace Tamagotchi.Models
{
    public class GenerationI
	{
        [JsonProperty("red-blue")]
        public RedBlue RedBlue { get; set; }

        [JsonProperty("yellow")]
        public RedBlue Yellow { get; set; }
    }
}
