using AnimalShelter.Extensions;
using AnimalShelter.Interfaces;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Data;
using AnimalShelter.Data.Entities;

namespace AnimalShelter.Services
{
    public class FavoriteService : IFavService
    {
        private readonly HttpContext httpContext;
        private readonly AnimalShelterDbContext ctx;

        public FavoriteService(AnimalShelterDbContext ctx, IHttpContextAccessor contextAccessor)
        {
            this.httpContext = contextAccessor.HttpContext ?? throw new Exception("HttpContext is null.");
            this.ctx = ctx;
        }

        public void Add(int id)
        {
            var existingIds = httpContext.Session.Get<List<int>>("FavItems");
            List<int> ids = existingIds ?? new();

            ids.Add(id);

            httpContext.Session.Set("FavItems", ids);
        }

        public void Clear()
        {
            httpContext.Session.Remove("FavItems");
        }

        public int GetFavSize()
        {
            var ids = httpContext.Session.Get<List<int>>("FavItems");
            return ids?.Count ?? 0;
        }

        public List<int> GetItemIds()
        {
            return httpContext.Session.Get<List<int>>("FavItems") ?? new List<int>();
        }

        public List<Animal> GetAnimals()
        {
            var existingIds = GetItemIds();

            return ctx.Animals
                .Include(x => x.Category)
                .Where(x => existingIds.Contains(x.Id))
                .ToList();
        }

    }
}