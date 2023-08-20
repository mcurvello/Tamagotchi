using RestEase;
using Tamagotchi.Models;

namespace Tamagotchi.Services
{
    public interface ITamagotchiService
    {
        [Get("/pokemon/{name}")]
        Task<Pokemon> GetPokemon([Path] string name);
    }
}