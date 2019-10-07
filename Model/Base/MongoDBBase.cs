using MongoDB.Bson;

namespace MongoExample.Model.Base
{
    public abstract class MongoDBBase
    {
        public ObjectId Id { get; set; }
    }
}

