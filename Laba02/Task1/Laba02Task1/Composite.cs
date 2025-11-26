using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba02Task1
{
    public interface IComponent
    {
        void Operation(int deep = 0);
    }

    public class File : IComponent
    {
        private string _name;
        public File(string name)
        {
            _name = name;
        }

        public void Operation(int deep = 0)
        {
            string indent = new string(' ', deep * 2);
            Console.WriteLine($"{indent}- {_name}");
        }
    }

    public class Composite : IComponent
    {
        private readonly List<IComponent> _components = new List<IComponent>();
        private string _name;
        public Composite(string name = "Folder")
        {
            _name = name;
        }
        public void Add(IComponent component)
        {
            _components.Add(component);
        }
        public void Operation(int deep = 0)
        {
            string indent = new string(' ', deep * 2);
            Console.WriteLine($"{indent}+ {_name}");
            foreach (IComponent component in _components)
            {
                component.Operation(deep + 1);
            }
        }

    }
}
