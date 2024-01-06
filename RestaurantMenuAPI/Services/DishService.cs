using RestaurantMenuAPI.Models;
using MongoDB.Driver;

namespace RestaurantMenuAPI.Services
{
    public class DishService : IDishService
    {
        private readonly IMongoCollection<Dish> _dishs;

        public DishService(IDishStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
           var database = mongoClient.GetDatabase(settings.DatabaseName);
           _dishs = database.GetCollection<Dish>(settings.DishsCollectionName);
        }
        public Dish Create(Dish dish)
        {
            _dishs.InsertOne(dish);
            return dish;
        }

        public List<Dish> Get()
        {
            return _dishs.Find(dish => true).ToList();
        }

        public Dish Get(string id)
        {
            return _dishs.Find(dish => dish.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _dishs.DeleteOne(dish => dish.Id == id);
        }

        public void Update(string id, Dish dish)
        {
            _dishs.ReplaceOne(dish => dish.Id == id, dish);
        }
    }
}
