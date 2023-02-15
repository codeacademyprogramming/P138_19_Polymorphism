using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal static class ExtentionMenthods
    {
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

        public static bool IsOdd(this int num)
        {
            return num % 2 == 1;
        }

        public static int[] GetValueIndexes(this string str, char value)
        {
            int[] indexes = new int[0];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == value)
                {
                    Array.Resize(ref indexes, indexes.Length + 1);
                    indexes[indexes.Length - 1] = i;
                }
            }

            return indexes;
        }
    }
}
