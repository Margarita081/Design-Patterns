using System;
using System.Collections.Generic;

namespace Task2.My_Controller
{
    public class CrudApiClient
    {
        private APITestController _controller = new APITestController();

        public void CrudOperation()
        {
            var entity = new SomeEntity { Name = "Test" };
            Console.WriteLine($"Create: {_controller.Create(entity).Name}");
            Console.WriteLine($"Update: {_controller.Update(1, entity).Name}");
            Console.WriteLine($"Delete: {_controller.Delete(1).Id}");
            Console.WriteLine($"GetOne: {_controller.GetOne(1).Name}");
        }
    }
}
