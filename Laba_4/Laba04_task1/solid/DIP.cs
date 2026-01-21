using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba04_task1.solid
{
    internal class DIP
    {
    }

    public class School
    {
        public void ToNotePresence()
        {
            Console.WriteLine("Presence confirmed.");
        }
        public void ToNoteLeteness()
        {
            Console.WriteLine("He was late.");
        }

        public void ToHaveLunch()
        {
            Console.WriteLine("Go to lunch");
        }
    }
    public class University
    {
        public void ToNotePresence()
        {
            Console.WriteLine("Presence confirmed.");
        }
        public void ToNoteLeteness()
        {
            Console.WriteLine("He was late.");
        }

        public void ToHaveLunch()
        {
            Console.WriteLine("Go to lunch");
        }
    }

    public class Job
    {
        public void ToNotePresence()
        {
            Console.WriteLine("Presence confirmed.");
        }
        public void ToNoteLeteness()
        {
            Console.WriteLine("He was late.");
        }

        public void ToHaveLunch()
        {
            Console.WriteLine("Go to lunch");
        }

        public void GiveASalary()
        {
            Console.WriteLine("He gives a salary.");
        }
    }


}
