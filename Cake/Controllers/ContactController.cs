using Microsoft.AspNetCore.Mvc;

namespace Cake.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
