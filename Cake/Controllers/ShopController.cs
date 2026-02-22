using Microsoft.AspNetCore.Mvc;

namespace Cake.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
