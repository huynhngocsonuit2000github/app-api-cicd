using Microsoft.AspNetCore.Mvc;

namespace app3.Controllers;

[ApiController]
[Route("[controller]")]
public class TestsController : ControllerBase
{ 
    private readonly ILogger<TestsController> _logger;

    public TestsController(ILogger<TestsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("kaka");
    }

    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        return Ok("kaka " + id);
    }
}
