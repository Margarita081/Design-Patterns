using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba02Task1
{
    public interface ICoffeeMachine
    {
        void Brew(string drinkName);
    }

    public class RealCoffeeMachine : ICoffeeMachine
    {
        private int _waterLevel = 1000;
        private int _beansGramm = 500;

        public bool HasEnoughResources()
        {
            return _waterLevel >= 150 && _beansGramm >= 20;
        }

        public void Brew(string drinkName)
        {
            if (!HasEnoughResources())
            {
                Console.WriteLine("Error. Doesn't have beans or water.");
                return;
            }

            Console.WriteLine($"Starting to make a {drinkName}");
            _waterLevel -= 150;
            _beansGramm -= 20;
            Console.WriteLine($"The {drinkName} is ready");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Water: {_waterLevel} ml, Beans: {_beansGramm} g");
        }
    }

    internal class CoffeeMachineProxy : ICoffeeMachine
    {
        private readonly RealCoffeeMachine _realMachine;

        public CoffeeMachineProxy()
        {
            _realMachine = new RealCoffeeMachine();
        }

        public void Brew(string drinkName)
        {
            Console.WriteLine(" Cheack resources");
            if (!_realMachine.HasEnoughResources())
            {
                Console.WriteLine("Doesn't have beans or water.");
                return;
            }

            _realMachine.Brew(drinkName);
        }
    }
}
