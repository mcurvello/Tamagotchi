using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class GameIndex
    {
        [JsonPropertyName("game_index")]
        public long GameIndexGameIndex { get; set; }

        [JsonPropertyName("version")]
        public Species Version { get; set; }
    }
}
