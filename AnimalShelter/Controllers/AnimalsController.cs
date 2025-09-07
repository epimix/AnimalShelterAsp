using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Data;
using AnimalShelter.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using AnimalShelter.Extensions;
using AnimalShelter.Models;

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
        public IActionResult Details(int id)
        {
            var animal = ctx.Animals.Include(x => x.Category).FirstOrDefault(x => x.Id == id);
            if (animal == null) return NotFound();

            return View(animal);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            SetCategoriesToViewBag();
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Animal animal)
        {
            if (!ModelState.IsValid)
            {
                SetCategoriesToViewBag();
                return View();
            }

            ctx.Animals.Add(animal);
            ctx.SaveChanges();

            TempData.Set(WebConstants.ToastMessage, new ToastModel("Product created successfully!"));

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var animal = ctx.Animals.Find(id);
            if (animal == null) return NotFound();

            SetCategoriesToViewBag();
            return View(animal);
        }

        [HttpPost]
        public IActionResult Edit(Animal animal)
        {
            if (!ModelState.IsValid)
            {
                SetCategoriesToViewBag();
                return View();
            }

            ctx.Animals.Update(animal);
            ctx.SaveChanges();

            TempData.Set(WebConstants.ToastMessage, new ToastModel("Product updated successfully!"));


            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var animal = ctx.Animals.Find(id);
            if (animal == null) return NotFound();

            ctx.Animals.Remove(animal);
            ctx.SaveChanges(); // submit changes to DB

            TempData.Set(WebConstants.ToastMessage, new ToastModel("Product deleted successfully!"));

            return RedirectToAction("Index");
        }


        private void SetCategoriesToViewBag()
        {
            var categories = new SelectList(ctx.Categories.ToList(), "Id", "Name");
            ViewBag.Categories = categories;
        }
    }
}
