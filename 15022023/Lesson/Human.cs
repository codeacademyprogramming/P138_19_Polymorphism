using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Human
    {
        public string Name;
        public string Surname;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Name} {Surname}");
        }

    }
}
