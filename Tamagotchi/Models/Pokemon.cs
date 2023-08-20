using System.Text.Json.Serialization;

namespace Tamagotchi.Models
{
    public class Pokemon
    {
        [JsonPropertyName("abilities")]
        public Ability[] Abilities { get; set; }

        [JsonPropertyName("base_experience")]
        public long BaseExperience { get; set; }

        [JsonPropertyName("forms")]
        public Species[] Forms { get; set; }

        [JsonPropertyName("game_indices")]
        public GameIndex[] GameIndices { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }

        [JsonPropertyName("held_items")]
        public HeldItem[] HeldItems { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        [JsonPropertyName("location_area_encounters")]
        public Uri LocationAreaEncounters { get; set; }

        [JsonPropertyName("moves")]
        public Move[] Moves { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("order")]
        public long Order { get; set; }

        [JsonPropertyName("past_types")]
        public object[] PastTypes { get; set; }

        [JsonPropertyName("species")]
        public Species Species { get; set; }

        [JsonPropertyName("sprites")]
        public Sprites Sprites { get; set; }

        [JsonPropertyName("stats")]
        public Stat[] Stats { get; set; }

        [JsonPropertyName("types")]
        public TypeElement[] Types { get; set; }

        [JsonPropertyName("weight")]
        public long Weight { get; set; }
    }
}
