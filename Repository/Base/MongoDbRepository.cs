using System.Collections.Generic;
using MongoDB.Driver;
using MongoExample.Model.Base;
using MongoDB.Bson;

namespace MongoExample.Repository.Base
{
    public class MongoDbRepository<TModel>
    where TModel : MongoDBBase
    {
        private readonly IMongoCollection<TModel> mongoCollection;

        public MongoDbRepository(
            string mongoDbConnectionString,
            string dbName,
            string collectionName)
        {
            var client = new MongoClient(mongoDbConnectionString);
            var database = client.GetDatabase(dbName);
            mongoCollection = database.GetCollection<TModel>(collectionName);
        }

        public virtual List<TModel> GetList()
        {
            return mongoCollection.Find(car => true).ToList();
        }

        public virtual TModel GetById(string Id)
        {
            var document = new ObjectId(Id);
            return mongoCollection.Find<TModel>(m => m.Id == document).FirstOrDefault();
        }

        public virtual TModel Create(TModel model)
        {
            mongoCollection.InsertOne(model);
            return model;
        }

        public virtual void Update(string id, TModel model)
        {
            var document = new ObjectId(id);
            mongoCollection.ReplaceOne(m => m.Id == document, model);
        }

        public virtual void Delete(TModel model)
        {
            mongoCollection.DeleteOne(m => m.Id == model.Id);
        }

        public virtual void Delete(string id)
        {
            var docId = new ObjectId(id);
            mongoCollection.DeleteOne(m => m.Id == docId);
        }
    }
}