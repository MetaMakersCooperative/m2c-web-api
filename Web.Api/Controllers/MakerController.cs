using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MakerController : ControllerBase
    {

        private readonly ILogger<MakerController> _logger;

        public MakerController(ILogger<MakerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Hello world";
        }
    }
}
