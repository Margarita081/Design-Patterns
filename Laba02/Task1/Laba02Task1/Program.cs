using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Laba02Task1.Builder;
using static Laba02Task1.CoffeeMachineFacade;
using static Laba02Task1.ControlLamp;
using static Laba02Task1.CoffeeMashine;
using static Laba02Task1.IIndicator;

namespace Laba02Task1
{
    internal class Program
    {
        static void Main()
        {
            // realization pattern Decorator
            var builder = new Builder.AmericanoBuilder();
            builder.AddEspresso();
            builder.AddWater();
            var americano = builder.GetDrink();
            IDecorator drinkComponent = new DrinkComponent(americano);
            IDecorator sweetAmericano = new AddSugar(drinkComponent);
            sweetAmericano.Operation();


            // realization pattern Facade
            var morningCoffee = new CoffeeMachineFacade();
            morningCoffee.MakeCoffee();


            // realization pattern Bridge
            ILamp lamp1 = new Bedroom();
            ILamp lamp2 = new Bathroom();
            RefinedControlLamp a = new RefinedControlLamp(lamp1);
            RefinedControlLamp b = new RefinedControlLamp(lamp2);
            a.Do();
            //a.DoSomething();
            //b.Do3();

            //adapter
            ILamp kitchenLamp = new Kitchen();
            IIndicator indicator = new LampAdapter(kitchenLamp);
            var coffeeMashine = new CoffeeMashine(indicator);

            coffeeMashine.Brew("Americano");
            coffeeMashine.Brew("Latte");

            //composite
            IComponent file1 = new File("Text_file.txt");
            IComponent file2 = new File("English_class.txt");
            IComponent file3 = new File("Programm_class.txt");
            Composite folder = new Composite();
            folder.Add(file1);
            folder.Add(file2);
            folder.Add(file3);
            Composite bigFolder = new Composite();
            bigFolder.Add(folder);
            bigFolder.Operation();

            //proxy
            ICoffeeMachine machine = new CoffeeMachineProxy();

            machine.Brew("Americano");
            machine.Brew("Latte");

            //flyweight

            var trees = new List<Tree>();

            var pineType = TreeFactory.GetTreeType("Pine", "Green");
            trees.Add(new Tree(10, 20, pineType));
            trees.Add(new Tree(30, 40, pineType));
            trees.Add(new Tree(50, 60, pineType));

            var oakType = TreeFactory.GetTreeType("Oak", "Dark green");
            trees.Add(new Tree(70, 80, oakType));
            trees.Add(new Tree(90, 100, oakType));

            foreach (var tree in trees)
            {
                tree.Draw();
            }
        }
    }
}
