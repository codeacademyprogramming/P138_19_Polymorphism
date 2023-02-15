using System;
using System.Globalization;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human
            {
                Name = "Abbas",
                Surname = "Abbasov"
            };

            Student std = new Student
            {
                Name = "Abbas",
                Surname = "Abbasov",
                GroupNo = "P123"
            };


            Console.WriteLine(human1);
            Console.WriteLine(std);


            byte age = 45;

            //implicit
            int ageInt = age;

            int numInt = 12;


            //explicit
            byte numByte = (byte)numInt;
            //byte numByte = Convert.ToByte(numInt);


            string numStr = "45";
            //int num = Convert.ToInt32(numStr);
            int num = int.Parse(numStr);

            Console.WriteLine(numByte);



            Human hm1 = new Human { Name = "Name1", Surname = "Surname1" };

            Student std1 = new Student { Name = "Name2", Surname = "Surname2", GroupNo = "P123" };

            Employee emp1 = new Employee { Name = "Name3", Surname = "Surname3", Position = "Developer" };

            Human hm2 = new Student { Name = "Name4", Surname = "Surname4", GroupNo = "P124" };

            //implicit
            //up-casting
            Human hm3 = emp1;




            //explciit
            //down-casting
            Student std2 = (Student)hm2;



            Human[] humans = { std1, emp1, hm1, hm2 };

            foreach (var item in humans)
            {
                if(item is Student)
                {
                    //Student student = (Student)item;
                    Student student = item as Student;
                    Console.WriteLine(student.GroupNo);
                }
            }


            Console.WriteLine("====================================");

            hm1.ShowInfo();
            emp1.ShowInfo();
            std1.ShowInfo();


            Console.WriteLine("====================================");

            Human human = hm1;
            Human studentHuman = std1;
            Human employeeHuman = emp1;

            human.ShowInfo();
            employeeHuman.ShowInfo();
            studentHuman.ShowInfo();


            object obj = std1;
            //Student newStd = (Student)obj;
            Student newStd = obj as Student;



            string name = "Abbas";

            object nameObj = name;

            int? number = 435;

            //implicit
            //boxing  value type -> object (reference type)
            object numberObj = 3455;

            //explicit
            //unboxing - object -> value type
            number = (int)numberObj;

            object[] arr = { 45, 65, "fdsf", 'd', true, std1 };



        }
    }
}
