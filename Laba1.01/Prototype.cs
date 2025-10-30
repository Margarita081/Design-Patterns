using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1._01
{
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    public class Drink : Prototype
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public List<string> Strings { get; set; }

        public Drink(string name, string size, List<string> strings)
        {
            Name = name;
            Size = size;
            Strings = new List<string>(strings);
        }

        public override Prototype Clone()
        {
            return new Drink(Name, Size, Strings);
        }

        public override string ToString() => $"Our order is {Name}, size is {Size} with {string.Join(", ", Strings)}";
    }
}
