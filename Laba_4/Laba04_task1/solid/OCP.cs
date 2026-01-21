using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laba04_task1.solid
{
    internal class OpenClosedPrincipal
    { }
    public class ShapeArea
    {

        public static string triangle = "1 / 2 * a * h";
        public static string circle = "pi * r^2";
        public static string squer = "s^2";

        public void Result()
        {
            Console.WriteLine("Choose  triangle, circle, squer");

            string choose = Console.ReadLine();

            if (choose == "triangle")
            {
                Console.WriteLine(triangle);
            }
            else if (choose == "circle")
            {
                Console.WriteLine(circle);
            }
            else if (choose == "squer")
            {
                Console.WriteLine(squer);
            }
            else
                Console.WriteLine("You didn't choose needed ");
        }
    }

}

