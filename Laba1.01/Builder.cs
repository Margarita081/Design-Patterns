using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1._01
{
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

        public class CapuchinoBuilder : DrinkSomeBuilder
        {
            public override void AddEspresso() => drink.Espresso = "double espresso";
            public override void AddMilk() => drink.Milk = "180 ml hot foam milk.";

            public override void AddSyrop() { }

            public override void AddWater() { }
        }

        public class CapuchinoWithAlmondMilkBuilder : DrinkSomeBuilder
        {
            public override void AddEspresso() => drink.Espresso = "double espresso";
            public override void AddMilk() => drink.Milk = "180 ml hot foam almond milk.";
            public override void AddSyrop() => drink.Syrop = "15 ml orange syrop.";

            public override void AddWater() { }
        }
    }
}
