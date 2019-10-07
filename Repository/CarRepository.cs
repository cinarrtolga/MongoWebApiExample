using MongoExample.Repository.Base;
using MongoExample.Model;

namespace MongoExample.Repository
{
    public class CarRepository : MongoDbRepository<CarModel>
    {
        public CarRepository(string dbConnectionString, string db, string collection)
        : base(dbConnectionString, db, collection)
        {

        }
    }
}

