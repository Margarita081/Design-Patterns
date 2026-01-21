using Laba04_task1.solid;
using Laba04_task1.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba04_task1
{
    internal class Program
    {
        static void Main()
        {
            //SR
            var user = new User();
            user.SendMail("Misha");

            //OCP
            var ocp = new ShapeArea();
            ocp.Result();

            //liskov
            var fish = new Kit();
            fish.Mammal();
            fish.Swim();
            fish.LaysEggs();

            //ISP
            var printer = new SimplePrinter();
            printer.Print();
            printer.Fax();

            //DIP
            var person = new School();
            person.ToNoteLeteness();
            person.ToHaveLunch();

            var person2 = new University();
            person2.ToNotePresence();
            person2.ToHaveLunch();

            // task2
            var handler = new BirdHandler();
            handler.DoBirdAction();
        }
    }
}
