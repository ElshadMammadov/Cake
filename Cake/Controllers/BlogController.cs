using Microsoft.AspNetCore.Mvc;

namespace Cake.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
