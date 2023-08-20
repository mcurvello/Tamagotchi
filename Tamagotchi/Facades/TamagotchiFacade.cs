using Tamagotchi.Models;
using Tamagotchi.Services;

namespace Tamagotchi.Facades
{
    public class TamagotchiFacade : ITamagotchiFacade
    {
        private readonly ITamagotchiService _tamagotchiService;

        public TamagotchiFacade(ITamagotchiService tamagotchiService)
        {
            _tamagotchiService = tamagotchiService;
        }

        public Task<Pokemon> GetPokemon(string name)
        {
            return _tamagotchiService.GetPokemon(name);
        }
    }
}