using Microsoft.AspNetCore.Mvc;

namespace HTTPRequest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("HTTPRequest Example API Running");
        }
    }
}
