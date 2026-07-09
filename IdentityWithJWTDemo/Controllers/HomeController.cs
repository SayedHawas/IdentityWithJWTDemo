using Microsoft.AspNetCore.Mvc;

namespace IdentityWithJWTDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
