using AnimalShelter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Data;
using AnimalShelter.Models;
using System.Diagnostics;

namespace AnimalShelter.Controllers
{
    public class HomeController : Controller
    {
        private readonly AnimalShelterDbContext ctx;

        public HomeController(AnimalShelterDbContext ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult Index()
        {
            var products = ctx.Animals.Include(x => x.Category).ToList();
            return View(products);
        }

        public IActionResult About()
        {
            // do logic here if needed
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}