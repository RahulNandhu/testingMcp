using Microsoft.AspNetCore.Mvc;
using testing.Interfaces;

namespace testing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController(ICommonServices commonServices) : ControllerBase
    {
        [HttpGet("greetings/{name}")]
        public async  Task<IActionResult> Greetings(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest("Name cannot be null or empty.");
            }

            var greeting = await commonServices.Greeting(name);
            return Ok(greeting);
        }
    }
}
