using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Laba02Task1
{

    public interface ILamp
    {
        void TurnOn();
        void TurnOff();
        void SwitchColor();
    }


    public class Kitchen : ILamp
    {
        public void TurnOn() => Console.WriteLine("turn on lamp in the kitchen");
        public void TurnOff() => Console.WriteLine("turn off lamp in the kitchen");
        public void SwitchColor() => Console.WriteLine("swith a color of the lamp in the kitchen");
    }
    public class Bathroom : ILamp
    {
        public void TurnOn() => Console.WriteLine("turn on lamp in the bathroom");
        public void TurnOff() => Console.WriteLine("turn off lamp in the bathroom");
        public void SwitchColor() => Console.WriteLine("swith a color of the lamp in the bathroom");
    }
    public class Bedroom : ILamp
    {
        public void TurnOn() => Console.WriteLine("turn on lamp in the bedroom");
        public void TurnOff() => Console.WriteLine("turn off lamp in the bedroom");
        public void SwitchColor() => Console.WriteLine("swith a color of the lamp in the bedroom");
    }

    public abstract class ControlLamp
    {
        protected ILamp _lamp;
        public ControlLamp(ILamp lamp)
        {
            _lamp = lamp;
        }
        public virtual void Do()
        {
            _lamp.TurnOn();
        }
        public virtual void Do2()
        {
            _lamp.TurnOff();
        }
        public virtual void Do3()
        {
            _lamp.SwitchColor();
        }

    }

    public class RefinedControlLamp : ControlLamp
    {
        public RefinedControlLamp(ILamp lamp) : base(lamp) { }
        public void DoSomething()
        {
            Do();
            Do2();
            Do3();
            Console.WriteLine("Choosed a room");
        }
    }
}
