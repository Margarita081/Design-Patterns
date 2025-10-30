using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1._01
{
    internal class AbstractFactory
    {

        public interface ICoffeeMashine
        {
            string Brewing();
        }

        public interface ICoffeeGrinder
        {
            string Grinding();
        }

        public interface ICoffeeBeans
        {
            string AddCoffee();
        }

        public class CafeCoffeeMashine : ICoffeeMashine
        {
            public string Brewing() => "Brewing coffee via Synesso.";
        }

        public class CafeCoffeeGrinder : ICoffeeGrinder
        {
            public string Grinding() => "Ginding coffee via Mahlkoenig Grinder.";
        }

        public class CafeCoffeeBeans : ICoffeeBeans
        {
            public string AddCoffee() => "Use Arabica Coffee Beans.";
        }


        public class RestoranCoffeeMashine : ICoffeeMashine
        {
            public string Brewing() => "Brewing coffee via Marzocco.";
        }

        public class RestoranCoffeeGrinder : ICoffeeGrinder
        {
            public string Grinding() => "Ginding coffee via Anfim Grinder.";
        }

        public class RestoranCoffeeBeans : ICoffeeBeans
        {
            public string AddCoffee() => "Use Blend Coffee Beans.";
        }


        public class OfficeCoffeeMashine : ICoffeeMashine
        {
            public string Brewing() => "Brewing coffee via Nespresso.";
        }

        public class OfficeCoffeeGrinder : ICoffeeGrinder
        {
            public string Grinding() => "Ginding coffee via Simple Grinder";
        }

        public class OfficeCoffeeBeans : ICoffeeBeans
        {
            public string AddCoffee() => "Use Krups Coffee Beans.";
        }


        public abstract class AbstractEquiomentFactory
        {
            public abstract ICoffeeMashine CreateCoffeeMachine();
            public abstract ICoffeeGrinder CreateCoffeeGrinder();
            public abstract ICoffeeBeans CreateCoffeeBeans();
        }


        public class CafeFactory : AbstractEquiomentFactory
        {
            public override ICoffeeMashine CreateCoffeeMachine() => new CafeCoffeeMashine();
            public override ICoffeeGrinder CreateCoffeeGrinder() => new CafeCoffeeGrinder();
            public override ICoffeeBeans CreateCoffeeBeans() => new CafeCoffeeBeans();
        }

        public class RestoranFactory : AbstractEquiomentFactory
        {
            public override ICoffeeMashine CreateCoffeeMachine() => new RestoranCoffeeMashine();
            public override ICoffeeGrinder CreateCoffeeGrinder() => new RestoranCoffeeGrinder();
            public override ICoffeeBeans CreateCoffeeBeans() => new RestoranCoffeeBeans();
        }

        public class OfficeFactory : AbstractEquiomentFactory
        {
            public override ICoffeeMashine CreateCoffeeMachine() => new OfficeCoffeeMashine();
            public override ICoffeeGrinder CreateCoffeeGrinder() => new OfficeCoffeeGrinder();
            public override ICoffeeBeans CreateCoffeeBeans() => new OfficeCoffeeBeans();
        }
    }
}
