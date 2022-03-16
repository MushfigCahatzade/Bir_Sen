using System;
using System.Collections.Generic;
using System.Text;

namespace TB2.TbModel
{
    internal class Person
    {
        public string Name { get; set; }    
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
    }
}
