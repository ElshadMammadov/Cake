using System.Diagnostics;
using Cake.Data;
using Cake.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cake.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            List<Category> datas = await _context.Categories.ToListAsync();
            return View(datas);
        }        
    }
}
