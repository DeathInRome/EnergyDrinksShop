using Microsoft.AspNetCore.Mvc;

namespace EnergyDrinksShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
