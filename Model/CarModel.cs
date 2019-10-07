using MongoDB.Bson.Serialization.Attributes;
using MongoExample.Model.Base;

namespace MongoExample.Model
{
    public class CarModel : MongoDBBase
    {
        [BsonElement("Brand")]
        public string Brand { get; set; }
        [BsonElement("Model")]
        public string Model { get; set; }
        [BsonElement("Package")]
        public string Package { get; set; }
        [BsonElement("ModelYear")]
        public string ModelYear { get; set; }
    }
}

