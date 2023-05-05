using Microsoft.AspNetCore.Mvc;

namespace Cod3rsGrowth.Web.Controller
{
    [ApiController]
    [Route("/i18n/i18n.properties")]
    public class I18nController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "i18n", "i18n.properties");
            return PhysicalFile(file, "text/html");
        }
    }
}
