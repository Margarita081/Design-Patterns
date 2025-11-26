using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba02Task1
{
    public class MakeEspresso
    {
        public string GramOfCoffee() => "measure the amount of coffee";
        public string GrindingCoffee() => "grinding coffee";
        public string HotWater() => "put hot water throw grinding coffee";
    }

    public class FoamMilk
    {
        public string GramOfMilk() => "measure the amount of milk";
        public string FlatMilk() => "whisk the milk into a flat foam";
        public string BigFoamMilk() => "whisk the milk into a smooth foam";
    }

    public class CoffeeMachineFacade
    {
        private MakeEspresso _espresso = new MakeEspresso();
        private FoamMilk _milk = new FoamMilk();

        public void MakeCoffee()
        {
            Console.WriteLine(_espresso.GramOfCoffee());
            Console.WriteLine(_espresso.GrindingCoffee());
            Console.WriteLine(_espresso.HotWater());
            Console.WriteLine(_milk.GramOfMilk());
            Console.WriteLine(_milk.FlatMilk());
            Console.WriteLine(_milk.BigFoamMilk());
            Console.WriteLine("Your coffee is ready!");
        }
    }

}
