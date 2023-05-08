using Microsoft.AspNetCore.Mvc;

namespace Cod3rsGrowth.Web.Controller
{
    [ApiController]
    [Route("")]
    public class InterfaceController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html");
            return PhysicalFile(file, "text/html");
        }
    }
}
