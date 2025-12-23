using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_03
{
    class Program
    {
        static void Main()
        {
            var shapes = new IShape[]
            {
                new Sphere(3),
                new Cube(4),
                new Parallelepiped(5, 2, 3),
                new Torus(6, 2),
            };
            var calculator = new Calculator();

            foreach (var shape in shapes)
            {
                shape.Result(calculator);
                Console.WriteLine($"{shape} V = {calculator.Formula}");
            }
        }
    }
}