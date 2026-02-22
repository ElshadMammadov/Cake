using Microsoft.AspNetCore.Mvc;

namespace Cake.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShopDetails()
        {
            return View();
        }

        public IActionResult ShopingCart()  
        {
            return View();
        }
        public IActionResult Wisslist()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult BlogDetails()
        {
            return View();
        }
    }
}