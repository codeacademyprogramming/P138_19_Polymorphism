using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Employee:Human
    {
        public string Position;

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Position}");
        }
    }
}
