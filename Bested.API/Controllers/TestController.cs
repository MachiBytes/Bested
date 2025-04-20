// Bested.API\Controllers\TestController.cs
using Microsoft.AspNetCore.Mvc;

namespace Bested.API.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult TestRunning()
        {
            return Ok("App is running.");
        }
    }
}
