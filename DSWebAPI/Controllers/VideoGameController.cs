using DSWebAPI.Models.Entities;
using DSWebAPI.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DSWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[EnableCors]
public class VideoGameController : ControllerBase
{
    private readonly IVideoGameRepository _gameRepo;

    public VideoGameController(IVideoGameRepository gameRepo)
    {
        _gameRepo = gameRepo;
    }

    [HttpGet("all")]
    public IActionResult Get()
    {
        return Ok(_gameRepo.ReadAll());
    }

    [HttpGet("one/{id}")]
    public IActionResult Get(int id)
    {
        var game = _gameRepo.Read(id);
        if (game == null)
        {
            return NotFound();
        }
        return Ok(game);
    }

    [HttpPost("create")]
    public IActionResult Post([FromForm] VideoGame game)
    {
        _gameRepo.Create(game);
        return CreatedAtAction("Get", new { id = game.Id }, game);
    }

    [HttpPut("update")]
    public IActionResult Put([FromForm] VideoGame game)
    {
        _gameRepo.Update(game.Id, game);
        return NoContent();
    }

    [HttpDelete("delete/{id}")]
    public IActionResult Delete(int id)
    {
        _gameRepo.Delete(id);
        return NoContent();
    }
}

