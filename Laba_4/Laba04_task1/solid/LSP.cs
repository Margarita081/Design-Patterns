using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba04_task1.solid
{
    public class LiskovSubstitutionPrinciple
    {
    }
    public class Fish
    {
        public virtual void Swim()
        {
            Console.WriteLine("The fish is swimming as fish.");
        }

        public virtual bool LaysEggs()
        {
            return true;
        }
    }

    public class Kit : Fish
    {
        public override void Swim()
        {
            Console.WriteLine("Kit can't swim like fish!");
        }

        public override bool LaysEggs()
        {
            return false;
        }

        public void Mammal()
        {
            Console.WriteLine("Kit is mammal.");
        }
    }
}
