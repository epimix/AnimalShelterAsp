using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Data;
using AnimalShelter.Data.Entities;

namespace AnimalShelter.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly AnimalShelterDbContext ctx;

        public AnimalsController(AnimalShelterDbContext ctx)
        {
            this.ctx = ctx;
        }
        public IActionResult Index()
        {
            // LEFT JOIN
            var model = ctx.Animals.Include(x => x.Category).ToList();

            return View(model);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = ctx.Categories.ToList();
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Animal animal)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = ctx.Categories.ToList();
                return View();
            }

            ctx.Animals.Add(animal);
            ctx.SaveChanges();
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var animal = ctx.Animals.Find(id);
            if (animal == null) return NotFound();

            ViewBag.Categories = ctx.Categories.ToList();
            return View(animal);
        }

        [HttpPost]
        public IActionResult Edit(Animal animal)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = ctx.Categories.ToList();
                return View();
            }

            ctx.Animals.Update(animal);
            ctx.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var animal = ctx.Animals.Find(id);
            if (animal == null) return NotFound();

            ctx.Animals.Remove(animal);
            ctx.SaveChanges(); // submit changes to DB

            return RedirectToAction("Index");
        }
    }
}
