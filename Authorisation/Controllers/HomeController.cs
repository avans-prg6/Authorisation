using Authorisation.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authorisation.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Geheimen()
        {
            if (User.IsInRole("SecretKeeper"))
            {
                return View(_context.Geheimen.ToList());

            }
            else
            {
                return View(_context.Geheimen.Where(g => g.SecurityLevel < 2).ToList());
            }
        }
    }
}
