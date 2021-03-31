using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<string> lista = new List<string>();
              lista.Add("Volkswagen");
              lista.Add("Ford");
              lista.Add("Peugeot");
              lista.Add("Citroen");
              lista.Add("Toyota");
              lista.Add("Subaru");
              lista.Add("Mitsubishi");
              lista.Insert(1, "Hyundai");
              lista.Add("Fiat");
              int count = lista.Count();

              foreach(string obj in lista)
              {
                  Console.WriteLine(obj);
              }
              Console.WriteLine(count);
              string s1 = lista.Find(x => x[0] == 'F'); //Expressão Lambda
              Console.WriteLine("Primeiro 'F': " + s1);

              string s2 = lista.FindLast(x => x[0] == 'F');
              Console.WriteLine("Ultimo 'F': " + s2);

              int pos1 = lista.FindIndex(x => x[0] == 'F');
              Console.WriteLine("First Index of 'F': " + pos1);
              int pos2 = lista.FindLastIndex(x => x[0] == 'F');
              Console.WriteLine("Last Index of 'F': " + pos2);

              List<string> lista2 = lista.FindAll(x => x.Length > 8);
              foreach(string obj in lista2)
              {
                  Console.WriteLine(obj);
              }

              lista.Remove("Fiat");
              foreach(string obj in lista)
              {
                  Console.WriteLine(obj);
              }

              lista.RemoveAll(x => x[0] == 'M');
              Console.ReadLine();*/

            //<-------------------------------------------------------------->

            Console.WriteLine("How many employees will be resgistred");
            int qtd = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for(int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("Employee #" + i);
                Console.Write("ID: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                employees.Add(new Employee(Id, name, salary));
            }

            Console.Write("Enter the employee ID that will have the salary increase: ");
            int empId = int.Parse(Console.ReadLine());
            Employee empSearch = employees.Find(x => x.ID == empId);

            if (empSearch != null)
            {
                Console.Write("Please enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                empSearch.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("That Id does not exist");
            }

            Console.WriteLine("Updated list of employees:");
            foreach(Employee obj in employees)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
        
    }
}
