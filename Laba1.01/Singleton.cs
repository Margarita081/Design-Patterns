using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laba1._01
{
    internal sealed class Singleton
    {
        public class CoffeeShop
        {
            public string Name { get; set; }
            public string Address { get; set; }

            public override string ToString()
            {
                return $"{Name} at: {Address}.";
            }
        }

        public class CurrentCoffeeShop
        {
            private static readonly Dictionary<string, string> ListCoffeeShops = new Dictionary<string, string>()
            {
                ["Starbucks"] = "st. Gogolya 42",
                ["Kafema"] = "st. Tverskaya 9",
                ["Coffee Brew"] = "st. Mira 13"
            };

            private static readonly Lazy<CurrentCoffeeShop> _instance = new Lazy<CurrentCoffeeShop>(() => new CurrentCoffeeShop());

            private CurrentCoffeeShop() { }

            public static CurrentCoffeeShop Instance => _instance.Value;

            public CoffeeShop ChooseCoffeeShop { get; private set; }

            public void AddCoffeeShop(string name)
            {
                if (ListCoffeeShops.TryGetValue(name, out string address))
                {
                    ChooseCoffeeShop = new CoffeeShop
                    {
                        Name = name,
                        Address = address
                    };

                    Console.WriteLine($"You choose Coffee shop is: {name}");
                }
            }

            public bool Choose => ChooseCoffeeShop != null;
            public CoffeeShop GetCoffeeShop()
            {
                if (!Choose)
                {
                    throw new InvalidOperationException("Coffee shop don't choose.");
                }
                return ChooseCoffeeShop;
            }
        }
    }
}
