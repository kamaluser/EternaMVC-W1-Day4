using Microsoft.AspNetCore.Mvc;
using MVC_Eterna.Data;
using MVC_Eterna.Models;

namespace MVC_Eterna.Controllers
{
    public class ServicesController : Controller
    {
        private AppDbContext _context;

        public ServicesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Services.ToList());
        }
    }
}
