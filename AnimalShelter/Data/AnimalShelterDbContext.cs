using Microsoft.EntityFrameworkCore;
using AnimalShelter.Data.Entities;

namespace AnimalShelter.Data
{
    public class AnimalShelterDbContext : DbContext
    {
        public AnimalShelterDbContext() {
            //Database.EnsureCreated();
        }
        public AnimalShelterDbContext(DbContextOptions<AnimalShelterDbContext> options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Category> Categories { get; set; }
        

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ShopPv421;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new List<Category>()
            {
                new() { Id = 1, Name = "Коти" },
                new() { Id = 2, Name = "Собаки" },
                new() { Id = 3, Name = "Хомяки" },
                new() { Id = 4, Name = "Мишки" },
                new() { Id = 5, Name = "Птахи" },
                new() { Id = 6, Name = "Риби" },
                new() { Id = 7, Name = "Кролики" },
                new() { Id = 8, Name = "Рептилії" },
                new() { Id = 9, Name = "Інші" }
            });

            modelBuilder.Entity<Animal>().HasData(new List<Animal>()
            {
                new() { Id = 1, Name = "Мурчик", CategoryId = 1, Age = 2, Gender = "Самець", Status = "Доступний", ImageUrl = "https://i.pinimg.com/736x/69/d4/f5/69d4f553a801270cc080e78402855353.jpg", Description = "Ласкавий кіт, любить гратися з м'ячиками. Дуже дружелюбний до людей." },
                new() { Id = 2, Name = "Рекс", CategoryId = 2, Age = 3, Gender = "Самець", Status = "Доступний", ImageUrl = "https://i.pinimg.com/736x/04/4d/b2/044db22d01a17a872b78b93f98d4b948.jpg", Description = "Дружелюбний пес, добре ладнає з дітьми. Потребує активних прогулянок." },
                new() { Id = 3, Name = "Хомка", CategoryId = 3, Age = 0, Gender = "Самка", Status = "Доступний", ImageUrl = "https://i.pinimg.com/736x/5e/ca/a9/5ecaa9e7ed0a5f4933d1a9ffccb78f9d.jpg", Description = "Маленький хомячок, дуже активний. Любить бігати в колесі." },
                new() { Id = 4, Name = "Мішка", CategoryId = 4, Age = 0, Gender = "Самка", Status = "Доступний", ImageUrl = "https://i.pinimg.com/736x/fc/fb/97/fcfb97ed81a0c03ce4bfdfeb82870d7f.jpg", Description = "Мишка-декоративна, дуже мила. Ідеально підходить для дітей." },
                new() { Id = 5, Name = "Кеша", CategoryId = 5, Age = 1, Gender = "Самець", Status = "Доступний", ImageUrl = "https://i.pinimg.com/736x/7a/b2/45/7ab2455981b1a5caa622b4372da2988f.jpg", Description = "Папуга, вміє говорити кілька слів. Дуже розумний і веселий." },
                new() { Id = 6, Name = "Золота рибка", CategoryId = 6, Age = 0, Gender = "Невідомо", Status = "Доступний", ImageUrl = "https://i.pinimg.com/1200x/c8/65/33/c86533f9898ea801e4e47edac4fdc1f0.jpg", Description = "Красиві золоті рибки для акваріуму. Потребують спеціального догляду." },
                new() { Id = 7, Name = "Кролик Білий", CategoryId = 7, Age = 0, Gender = "Самка", Status = "Доступний", ImageUrl = "https://i.pinimg.com/736x/61/57/e8/6157e8486c7b0edd02f7c23e8e843dcd.jpg", Description = "Білий кролик, дуже пухнастий. Любить моркву та зелень." },
            });
        }
    }
}
