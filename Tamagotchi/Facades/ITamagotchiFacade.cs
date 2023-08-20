using Tamagotchi.Models;

namespace Tamagotchi.Facades
{
	public interface ITamagotchiFacade
	{
		public Task<Pokemon> GetPokemon(string name);
	}
}
