using System;
using System.Collections.Generic;
using System.Text;

namespace TB2.TbModel
{
    internal class Student : Person
    {
        public string Person { get; set; }

        public Student(string name,int age,string person) : base(name, age)
        {
            Person = person;
        }
    }
}
