using Microsoft.AspNetCore.Mvc;

namespace MyFuel.Presentation.Controllers
{
    [ApiController]
    [Route("api")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello Api!";
        }
    }
}
