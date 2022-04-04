using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35.App_35
{
    internal class Department
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }    
        List<Employee> employees { get; set; }
        public Department(string name)
        {
            _id++;
            Id = _id;
            Name = name;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} - Name: {Name} ");
        }
    }
}
