using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int _id, string _name, double _salary)
        {
            ID = _id;
            Name = _name;
            Salary = _salary;
        }

        public void increaseSalary(double percentage)
        {
            Salary = Salary + (Salary * (percentage / 100));
        }

        public override string ToString()
        {
            return ID + ", " + Name + ", " + Salary;
        }
    }
}
