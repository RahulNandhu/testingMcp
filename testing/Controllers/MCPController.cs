using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testing.Interfaces;

namespace testing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MCPController(IMCPTools mcpTools) : ControllerBase
    {
        [HttpGet("StudentCources")]
        public async Task<IActionResult> getStudentCources()
        {
            await Task.Delay(100);
            return Ok(await mcpTools.GetStudentCources());
        }

        [HttpGet("FacultyCources")]
        public async Task<IActionResult> getFacultyCources()
        {
            await Task.Delay(100);
            return Ok(await mcpTools.GetFacultyCources());
        }

        [HttpGet("StaffDuties")]
        public async Task<IActionResult> getStaffDuties()
        {
            await Task.Delay(100);
            return Ok(await mcpTools.GetStaffDuties());
        }
    }
}
