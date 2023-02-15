using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Student
    {
        string _fullName;
        string _groupNo;
        public byte Age;

        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                    _groupNo = value;
            }
        }

        public string FullName
        {
            get=> _fullName;
            set
            {
                if(CheckFullName(value))
                    _fullName = value;
            }
        }

        public static bool CheckGroupNo(string groupNo)
        {
            if (string.IsNullOrWhiteSpace(groupNo) || groupNo.Length<4) return false;

            if (!char.IsUpper(groupNo[0])) return false;

            for (int i = 1; i < groupNo.Length; i++)
            {
                if (!char.IsDigit(groupNo[i]))
                    return false;
            }

            return true;
        }

        public static bool CheckFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return false;

            var words = fullName.Split(' ');

            if(words.Length!=2) return false;

            if (!char.IsUpper(words[0][0]) || !char.IsUpper(words[1][0]) || words[0].Length<3 || words[1].Length<3) return false;

            for (int i = 1; i < words[0].Length; i++)
            {
                if (!char.IsLower(words[0][i]))
                    return false;
            }

            for (int i = 1; i < words[1].Length; i++)
            {
                if (!char.IsLower(words[1][i]))
                    return false;
            }

            return true;

        }
    }
}
