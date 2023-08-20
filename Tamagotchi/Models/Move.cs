using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class Move
    {
        [JsonPropertyName("move")]
        public Species MoveMove { get; set; }

        [JsonPropertyName("version_group_details")]
        public VersionGroupDetail[] VersionGroupDetails { get; set; }
    }
}
