using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace RestaurantMenuAPI.Models
{
    [BsonIgnoreExtraElements]
    public class Dish
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("MenuName")]
        public string? MenuName { get; set; }

        [BsonElement("DishName")]
        public string? DishName { get; set; }

        [BsonElement("Description")]
        public string? Description { get; set; }

        [BsonElement("Price")]
        public decimal Price { get; set; }

        [BsonElement("Category")]
        public string? Category { get; set; }       

        [BsonElement("Ingredients")]
        public string? Ingredients { get; set; }

        [BsonElement("Allergens")]
        public string? Allergens { get; set; }

        [BsonElement("PreparationTime")]
        public TimeSpan PreparationTime { get; set; }

        [BsonElement("Availability")]
        public Dictionary<string, Tuple<string, string>> Availability { get; set; }

        [BsonElement("DeactivationStatus")]
        public bool DeactivationStatus { get; set; }

        [BsonElement("Calories")]
        public int Calories { get; set; }

        [BsonElement("SpicinessLevel")]
        public String? SpicinessLevel { get; set; }

        [BsonElement("PortionSize")]
        public decimal PortionSize { get; set; }

        [BsonElement("ImageUrl")]
        public String? ImageUrl { get; set; }

        [BsonElement("DishRating")]
        public string? DishRating { get; set; }

        [BsonElement("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [BsonElement("Origin")]
        public string? Origin { get; set; }
    }
}
