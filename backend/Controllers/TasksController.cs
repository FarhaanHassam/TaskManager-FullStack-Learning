using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTasks()
        {
            return Ok("Tasks endpoint is working!");
        }
    }
}