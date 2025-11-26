using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba02Task1
{
    public interface IIndicator
    {
        void StartBrewing();
        void StopBrewing();
    }

    public class LampAdapter : IIndicator
    {
        private readonly ILamp _lamp;
        public LampAdapter(ILamp lamp)
        {
            _lamp = lamp;
        }

        public void StartBrewing()
        {
            _lamp.TurnOn();
            _lamp.SwitchColor();
        }
        public void StopBrewing()
        {
            _lamp.TurnOff();
        }
    }

    public class CoffeeMashine
    {
        private readonly IIndicator _indicator;
        public CoffeeMashine(IIndicator indicator)
        {
            _indicator = indicator;
        }

        public void Brew(string drink)
        {
            Console.WriteLine($"Start to make a {drink}");
            _indicator.StartBrewing();
            Console.WriteLine($"{drink} is ready");
            _indicator.StopBrewing();
        }
    }
}
