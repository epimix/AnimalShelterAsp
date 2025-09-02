using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Data.Entities
{
    public class Animal
    {
        public int Id { get; set; }

        [Required, MinLength(2, ErrorMessage = "Ім'я повинно мати принаймні 2 символи.")]
        [RegularExpression(@"^[А-Я].*", ErrorMessage = "Ім'я повинно починатися з великої літери.")]
        public string Name { get; set; }
        public string? ImageUrl { get; set; }

        [Range(0, 30, ErrorMessage = "Вік повинен бути від 0 до 30 років.")]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; } = "Невідомо";

        [Required]
        public string Status { get; set; } = "Доступний"; // Доступний, Зарезервований, Прийнятий

        [MinLength(10), MaxLength(3000)]
        public string? Description { get; set; }
        public int CategoryId { get; set; }

        // ----- navigation properties
        public Category? Category { get; set; }
    }
}
