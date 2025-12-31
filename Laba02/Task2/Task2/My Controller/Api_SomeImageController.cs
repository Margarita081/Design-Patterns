using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Task2.My_Controller
{
    [ApiController]
    [Route("[controller]")]
    public class Api_SomeImageController : ControllerBase
    {
        private readonly APITestController _controller = new APITestController();
        [HttpGet("{id}")]
        public SomeImageEntity GetImage(int id)
        {
            _controller.GetOne(id);
            return new SomeImageEntity { Id = id };
        }
        [HttpPost]
        public SomeImageEntity SetImage(SomeImageEntity imageEntity)
        {
            _controller.Update(imageEntity.Id, imageEntity);
            return imageEntity;
        }
        [HttpGet("filter")]
        public List<SomeImageEntity> GetEntitiesByFilter(string filter)
        {
            _controller.GetByFilter();
            return new List<SomeImageEntity>();
        }
    }
}
