using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Data;
using AnimalShelter.Extensions;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly AnimalShelterDbContext ctx;

        public FavoriteController(AnimalShelterDbContext ctx)
        {
            this.ctx = ctx;
        }
        // GET: Cart
        public ActionResult Index()
        {
            var existingIds = HttpContext.Session.Get<List<int>>("FavItems") ?? new List<int>();

            var items = ctx.Animals
                .Include(x => x.Category)
                .Where(x => existingIds.Contains(x.Id))
                .ToList();

            return View(items);
        }

        public ActionResult Add(int id) // 3, 5
        {
            var existingIds = HttpContext.Session.Get<List<int>>("FavItems");
            List<int> ids = existingIds ?? new();
            ids.Add(id);

            HttpContext.Session.Set("FavItems", ids);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Delete(int id)
        {
            var existingIds = HttpContext.Session.Get<List<int>>("FavItems");
            List<int> ids = existingIds ?? new();

            ids.Remove(id);
            HttpContext.Session.Set("FavItems", ids);

            TempData.Set(WebConstants.ToastMessage, new ToastModel("Product deleted successfully!"));

            return RedirectToAction("Index");
        }


        public ActionResult Remove()
        {
            return View();
        }
    }
}