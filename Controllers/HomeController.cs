using Microsoft.AspNetCore.Mvc;

namespace TpMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
