using RestaurantMenuAPI.Models;

namespace RestaurantMenuAPI.Services
{
    public interface IDishService
    {
        List<Dish> Get();
        Dish Get(string id);
        Dish Create(Dish dish);
        void Update(string id, Dish dish);
        void Remove(string id);
    }
}
