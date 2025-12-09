using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Task2.My_Controller
{
    [ApiController]
    [Route("[controller]")]
    public class APIController : ControllerBase
    {
        public static Storage Storage { get; set; } = new Storage();

        [HttpPost]
        public SomeEntity Create(SomeEntity entity)
        {
            return entity;
        }

        [HttpPut("{id}")]
        public SomeEntity Update(Guid id, SomeEntity entity)
        {
            return entity;
        }

        [HttpGet("{id}")]
        public SomeEntity GetOne(Guid id)
        {
            return new SomeEntity
            {
                Id = id,
                Name = "Test",
                Description = "Test",
                Status = "Active",
            };
        }

        [HttpGet]
        public List<SomeEntity> GetMany()
        {
            return new List<SomeEntity>();
        }

        [HttpGet("filter")]
        public List<SomeEntity> GetByFilter()
        {
            return new List<SomeEntity>();
        }

        [HttpDelete("{id}")]
        public SomeEntity Delete(Guid id)
        {
            return new SomeEntity { Id = id };
        }

        [HttpPost("deletemany")]
        public List<SomeEntity> DeleteMany(List<Guid> ids)
        {
            return new List<SomeEntity>();
        }

        [HttpGet("{id}/print")]
        public SomeEntity Print(Guid id)
        {
            return new SomeEntity { Id = id, Name = "Print test" };
        }

        [HttpPost("printmany")]
        public List<SomeEntity> PrintMany(List<Guid> ids)
        {
            return new List<SomeEntity>();
        }

        [HttpPut("{id}/status")]
        public SomeEntity SetStatus(Guid id, string status)
        {
            return new SomeEntity { Id = id, Status = status };
        }

        [HttpPost("{id}/feactivate")]
        public SomeEntity Deactivate(Guid id)
        {
            return new SomeEntity { Id = id, Status = "Inactive" };
        }

        [HttpPost("{id}/activate")]
        public SomeEntity Activate(Guid id)
        {
            return new SomeEntity { Id = id, Status = "Active" };
        }
    }
}
