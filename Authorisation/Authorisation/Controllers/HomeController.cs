using Microsoft.AspNetCore.Mvc;

namespace Authorisation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
