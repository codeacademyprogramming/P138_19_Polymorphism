using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 45;

            Console.WriteLine(number.IsEven());

            Console.WriteLine(number.IsOdd());

            string name = "abbasa";
            var wantedIndexes = name.GetValueIndexes('a');

            foreach (var index in wantedIndexes)
            {
                Console.WriteLine(index);
            }


            string fullname;
            do
            {
                Console.Write("FullName: ");
                fullname = Console.ReadLine();
            } while (!Student.CheckFullName(fullname));
           

            string groupNo;
            do
            {
                Console.Write("GroupNo: ");
                groupNo = Console.ReadLine();

            } while (!Student.CheckGroupNo(groupNo));

            byte age;
            string ageStr;
            do
            {
                Console.Write("Age: ");
                ageStr = Console.ReadLine();

            } while (!byte.TryParse(ageStr,out age));
            

            Student student = new Student
            {
                Age = age,
                FullName = fullname,
                GroupNo = groupNo
            };

            Console.WriteLine("Telebe yaradildi");

        }
    }
}
