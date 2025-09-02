namespace AnimalShelter.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // ----- navigation properties
        public ICollection<Animal>? Animals { get; set; }
    }
}
