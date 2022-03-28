using System;
using System.Collections.Generic;
using System.Text;

namespace JM_S.JM_S
{
    internal class Student
    {

        public string Id { get; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }

        public Student(string Name, string SurName, int Point)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.Point = Point;
        }

        public Student()
        {
        }

        public static void ShowInfo()
        {
            Console.WriteLine("ID --> 7MQGH8"); 
            Console.WriteLine("Name --> Mushfig"); 
            Console.WriteLine("SurName --> Ayvazov"); 
            Console.WriteLine("Age --> 19"); 
            Console.WriteLine("Point --> 100"); 


        }

        public static bool operator >(Student p1,Student p2)
        {
            return p1.Point > p2.Point;
        }
        public static bool operator <(Student p1, Student p2)
        {
            return p1.Point < p2.Point;
        }













    }
}
