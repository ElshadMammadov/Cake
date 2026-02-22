using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

namespace Cake.Controllers
{
    public class HomeController : Controller
    {  
        public IActionResult Index()
        {
            return View();
        }        
    }
}
