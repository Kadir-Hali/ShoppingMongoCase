using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShoppingMongoCase.Entities
{
    public class ProductImage
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductImageId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string ImageUrl { get; set; }
    }
}
