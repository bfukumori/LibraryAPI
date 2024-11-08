using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public abstract class LibraryAPIBaseController : ControllerBase
{
    [HttpGet("healthy")]
    public IActionResult Healthy()
    {
        return Ok("It's working!");
    }
}
