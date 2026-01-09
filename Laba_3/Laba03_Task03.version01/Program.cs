using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba03_Task03.version01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            var audi = new Audi();
            var volvo = new Volvo();
            var tiger = new Tiger();

            container.Add(audi);
            container.Add(volvo);
            container.Add(tiger);

            audi.Name = "Audi RS5666";
            audi.Color = "Red";

            volvo.Tonnage = "40";

            tiger.CrewSize = "5";

        }
    }
}
