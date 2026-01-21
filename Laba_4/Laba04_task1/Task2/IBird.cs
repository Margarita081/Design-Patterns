using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba04_task1.Task2
{
    public interface IBird
    {
        void ProduceEgg();
        void DefendEgg();
    }
    public interface ISingAndDance
    {
        void SearchForSpause();
        void Sing();
        void Dance();
    }
    public interface IWalk
    {
        void Walk();
    }

    public interface IFly
    {
        void Fly();
    }

}
