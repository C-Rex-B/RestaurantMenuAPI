namespace RestaurantMenuAPI.Models
{
    public class DishStoreDatabaseSettings : IDishStoreDatabaseSettings
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
        public string DishsCollectionName { get; set; } = string.Empty;
    }
}
