using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba02Task1
{
    public class TreeType
    {
        private string _name;
        private string _color;

        public TreeType(string name, string color)
        {
            _name = name;
            _color = color;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Drawing {_name} [{_color}], position: ({x}, {y})");
        }
    }

    public class TreeFactory
    {
        private static readonly Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>();

        public static TreeType GetTreeType(string name, string color)
        {
            string key = $"{name}_{color}";
            if (!_treeTypes.ContainsKey(key))
            {
                _treeTypes[key] = new TreeType(name, color);
                Console.WriteLine($"Flyweight: create new type '{key}'");
            }
            return _treeTypes[key];
        }
    }

    public class Tree
    {
        private int _x, _y;
        private TreeType _type;

        public Tree(int x, int y, TreeType type)
        {
            _x = x;
            _y = y;
            _type = type;
        }

        public void Draw() => _type.Draw(_x, _y);
    }
}
