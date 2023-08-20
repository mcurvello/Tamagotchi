using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Facades;

namespace Tamagotchi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TamagotchiController : Controller
    {
        private readonly ITamagotchiFacade _tamagotchiFacade;

        public TamagotchiController(ITamagotchiFacade tamagotchiFacade)
        {
            _tamagotchiFacade = tamagotchiFacade;
        }

        [HttpGet]
        public async Task<IActionResult> GetPokemon([FromHeader] string name)
        {
            try
            {
                if (name is null)
                {
                    return BadRequest();
                }

                return Ok(await _tamagotchiFacade.GetPokemon(name));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
