namespace RestaurantMenuAPI.Models
{
    public interface IDishStoreDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string DishsCollectionName { get; set; }
    }
}
