using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;

namespace Task2.My_Controller
{
    public class ApiClientFlex
    {
        private APITestController _controller = new APITestController();

        public void FlaxiOperation()
        {
            Console.WriteLine($"Filetr: {_controller.GetByFilter().Count}");
            Console.WriteLine($"DeleteMany: {_controller.DeleteMany(new List<int> { 1, 2 }).Count}");
            Console.WriteLine($"Print: {_controller.Print(1).Name}");
            Console.WriteLine($"PrintMany: {_controller.PrintMany(new List<int> { 1, 2 }).Count}");
            Console.WriteLine($"SetStatus: {_controller.SetStatus(1, "Pending").Status}");
            Console.WriteLine($"Deactivate: {_controller.Deactivate(1).Status}");
            Console.WriteLine($"Activate: {_controller.Activate(1).Status}");
        }
    }
}
