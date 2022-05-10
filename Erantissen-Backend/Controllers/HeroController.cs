﻿using Erantissen_Backend.App.Models;
using Erantissen_Backend.App.Services;
using Erantissen_Backend.Query.Models;
using Erantissen_Backend.Query.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Erantissen_Backend.Controllers
{
    [ApiController]
    [Route("controller")]
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
            return hero;
        }

        [HttpPost()]
        public async Task<ActionResult> CreateHero([FromBody] CreateHeroRequest request)
        {
            await _service.CreateHeroAsync(request);
            return Ok("Hero created!");
        }
    }
}