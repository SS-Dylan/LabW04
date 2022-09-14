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
}

