using AnimalShelter.Data.Entities;

namespace AnimalShelter.Interfaces
{
    public interface IFavService
    {
        List<int> GetItemIds();
        List<Animal> GetAnimals();

        void Add(int id);
        void Clear();
        int GetFavSize();
    }
}