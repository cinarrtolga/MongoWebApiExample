using MongoExample.Model.Base;

namespace MongoExample.Model
{
    public class CarModel : MongoDBBase
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Package { get; set; }
        public string ModelYear { get; set; }
    }
}

