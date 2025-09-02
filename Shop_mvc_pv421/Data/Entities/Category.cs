namespace AnimalShelter.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // ----- navigation properties
        public ICollection<Animal>? Animals { get; set; }
    }
}
