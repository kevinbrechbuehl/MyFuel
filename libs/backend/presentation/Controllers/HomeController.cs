using System;

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
            var now = DateTime.Now;
            return $"Hi guest! It's {now:D} at {now:t}.";
        }
    }
}
