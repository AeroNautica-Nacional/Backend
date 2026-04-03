using Microsoft.AspNetCore.Mvc;

namespace AeroMexic.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
