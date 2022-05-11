using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wordle.Api.Data;
using Wordle.Api.Services;

namespace Wordle.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PlayerController : ControllerBase
{

    private readonly PlayersService _service;
    public PlayerController(PlayersService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<Player> Get()
    {
        return _service.GetAverageAttempts();

    }

    [HttpPost]
    public IActionResult Post([FromBody] Player averageAttempts)
    {
        _service.Update(averageAttempts.AverageAttempts, averageAttempts.GameCount);
        return Ok();
    }
    public class PlayerPost
    {
        public string Name { get; set; }
        public int AverageAttempts { get; set; }
        public int GamesCount { get; set; }
    }
}

