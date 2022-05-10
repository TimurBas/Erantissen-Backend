using Erantissen_Backend.App.Models;
using Erantissen_Backend.App.Services;
using Erantissen_Backend.Query.Models;
using Erantissen_Backend.Query.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Erantissen_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroController: ControllerBase
    {
        private readonly IHeroService _service;
        private readonly IHeroQuery _query;
        public HeroController(IHeroService service, IHeroQuery query)
        {
            _service = service;
            _query = query;
        }

        [HttpGet("{imageNumber}")]
        public ActionResult<HeroReadDto> GetHero(int imageNumber)
        {
            var hero = _query.GetHero(imageNumber);
            return Ok(hero);
        }

        [HttpGet]
        public ActionResult<List<HeroReadDto>> GetHeros()
        {
            var heros = _query.GetAll();
            return Ok(heros);
        }

        [HttpPost()]
        public async Task<ActionResult> CreateHero([FromBody] CreateHeroRequest request)
        {
            await _service.CreateHeroAsync(request);
            return Ok("Hero created!");
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateHero([FromBody] UpdateHeroRequest request)
        {
            await _service.UpdateHeroAsync(request);
            return Ok("Hero updated!");
        }

        [HttpDelete("{imageNumber}")]
        public async Task<ActionResult> DeleteHero([FromRoute] int imageNumber)
        {
            await _service.DeleteHeroAsync(imageNumber);
            return Ok($"Hero number {imageNumber} deleted!");
        }
    }
}
