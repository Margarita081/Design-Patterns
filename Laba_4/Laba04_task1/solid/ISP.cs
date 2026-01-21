using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba04_task1.solid
{
    internal class InterfaceSegregationPrinciple
    {
    }

    public interface IMachine
    {
        void Print();
        void Scan();
        void Fax();
    }

    public class SimplePrinter : IMachine
    {
        public void Print() => Console.WriteLine("Printing...");
        public void Scan() => Console.WriteLine("This printer cannot scan.");
        public void Fax() => Console.WriteLine("This printer cannot fax.");
    }
}
