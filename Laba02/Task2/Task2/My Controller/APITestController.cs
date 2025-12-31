using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Task2.My_Controller
{
    [ApiController]
    [Route("/api[controller]")]
    public class APITestController : ControllerBase
    {
        public static Storage Storage { get; set; } = new();

        [HttpPost]
        public SomeEntity Create(SomeEntity entity)
        {
            return entity;
        }

        [HttpPut("{id}")]
        public SomeEntity Update(int id, SomeEntity entity)
        {
            return entity;
        }

        [HttpGet("{id}")]
        public SomeEntity GetOne(int id)
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
        public SomeEntity Delete(int id)
        {
            return new SomeEntity { Id = id };
        }

        [HttpPost("deletemany")]
        public List<SomeEntity> DeleteMany(List<int> ids)
        {
            return new List<SomeEntity>();
        }

        [HttpGet("{id}/print")]
        public SomeEntity Print(int id)
        {
            return new SomeEntity { Id = id, Name = "Print test" };
        }

        [HttpPost("printmany")]
        public List<SomeEntity> PrintMany(List<int> ids)
        {
            return new List<SomeEntity>();
        }

        [HttpPut("{id}/status")]
        public SomeEntity SetStatus(int id, string status)
        {
            return new SomeEntity { Id = id, Status = status };
        }

        [HttpPost("{id}/deactivate")]
        public SomeEntity Deactivate(int id)
        {
            return new SomeEntity { Id = id, Status = "Inactive" };
        }

        [HttpPost("{id}/activate")]
        public SomeEntity Activate(int id)
        {
            return new SomeEntity { Id = id, Status = "Active" };
        }
    }
}
