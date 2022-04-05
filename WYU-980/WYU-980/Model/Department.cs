using System;
using System.Collections.Generic;
using System.Text;

namespace WYU_980.Model
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Employee> Employees { get; set; }
        public void AddEmployee()
        {

        }
        public void GetEmployeeById(int id)
        {

        }
        public void RemoveEmployee(int id) 
        {

        }
    }
}
