using Microsoft.AspNetCore.Mvc;
using MongoExample.Model;
using MongoExample.Repository;

namespace MongoExample.Controllers
{
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        public CarRepository _carRepository { get; set; }

        public CarController(CarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpPost, Route("AddModel")]
        public ActionResult AddModel(CarModel model)
        {
            return Ok(_carRepository.Create(model));
        }

        [HttpGet, Route("GetAllModels")]
        public ActionResult GetAllModels()
        {
            return Ok(_carRepository.GetList());
        }
    }
}
