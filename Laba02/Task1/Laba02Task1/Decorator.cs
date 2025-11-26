using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba02Task1
{
    public interface IDecorator
    {
        void Operation();
    }

    internal class Builder
    {
        public class DrinkSome
        {
            public string Espresso { get; set; }
            public string Water { get; set; }
            public string Syrop { get; set; }
            public string Milk { get; set; }

            public override string ToString()
            {
                var p = new List<string>();

                if (!string.IsNullOrEmpty(Espresso)) p.Add(Espresso);
                if (!string.IsNullOrEmpty(Water)) p.Add(Water);
                if (!string.IsNullOrEmpty(Syrop)) p.Add(Syrop);
                if (!string.IsNullOrEmpty(Milk)) p.Add(Milk);

                return p.Count > 0
                    ? string.Join(", ", p)
                    : "Empty drink";
            }
        }
        public class DrinkComponent : IDecorator
        {
            private readonly Builder.DrinkSome _drink;

            public DrinkComponent(Builder.DrinkSome drink)
            {
                _drink = drink;
            }

            public void Operation()
            {
                Console.WriteLine($"Drink: {_drink}");
            }
        }
        public abstract class DrinkSomeBuilder
        {
            protected DrinkSome drink = new DrinkSome();

            public DrinkSome GetDrink() { return drink; }

            public abstract void AddEspresso();
            public abstract void AddWater();
            public abstract void AddSyrop();
            public abstract void AddMilk();
        }

        public class AmericanoBuilder : DrinkSomeBuilder
        {
            public override void AddEspresso() => drink.Espresso = "Double espresso";

            public override void AddWater() => drink.Water = "180 ml hot water";

            public override void AddSyrop() { }

            public override void AddMilk() { }
        }
    }

    public abstract class MyDecorator : IDecorator
    {
        protected IDecorator _decorator;
        public MyDecorator(IDecorator decorator)
        {
            _decorator = decorator;
        }
        public virtual void Operation()
        {
            _decorator.Operation();
        }
    }

    public class AddSugar : MyDecorator
    {
        public AddSugar(IDecorator decorator) : base(decorator) { }
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("+ add sugar.");
        }
    }
}