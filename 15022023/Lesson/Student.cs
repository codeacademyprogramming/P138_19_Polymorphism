﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Student:Human
    {
        public string GroupNo;

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} {Surname} {GroupNo}");
        }

        public override string ToString()
        {
            return $"FullName: {Name} {Surname} - GroupNo: {GroupNo}";
        }

    }
}
