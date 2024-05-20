using Microsoft.AspNetCore.Mvc;

namespace PipelineDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("HEE HEE");
        }
    }
}
