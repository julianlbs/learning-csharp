using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI_DotNet8.Entities;

namespace SuperHeroAPI_DotNet8.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SuperHeroController : ControllerBase
  {
    [HttpGet]
    public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
    {
      var heroes = new List<SuperHero> {
        new SuperHero
        {
          Id = 1,
          Name = "Spiderman",
          FirstName = "Peter",
          LastName = "Parker",
          Place = "New York"
        }
      };

      await AsyncConsoleWork();

      return Ok(heroes);
    }

    private static async Task<int> AsyncConsoleWork()
    {
      // main body here 
      return 0;
    }
  }
}