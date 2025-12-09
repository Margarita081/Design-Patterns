using Microsoft.AspNetCore.Mvc;

namespace Task2.My_Controller
{
    [Route("[controller]")]
    [ApiController]
    public class Api_SomeImageController : ControllerBase
    {
        private APIController controller = new APIController();
        [HttpGet]
        public SomeImageEntity GetImage(int id)
        {
            controller.GetOne();
            return new SomeImageEntity();
        }
        [HttpGet]
        public SomeImageEntity SetImage(SomeImageEntity Image_entity)
        {
            controller.Update();
            return Image_entity;
        }
        [HttpGet]
        public List<SomeImageEntity> GetEntitiesByFilter(string filter)
        {
            controller.GetByFilter();
            return new List<SomeImageEntity>();
        }
    }
}
