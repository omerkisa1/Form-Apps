using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation2
{
    class Program
    {
        class Company
        {
            public string Name { get; set; }
            public List<Employee> Employees { get; set; }

            public Company(string name)
            {
                Name = name;
                Employees = new List<Employee>();
            }
            
            public void addEmployee(Employee employee)
            {
                Employees.Add(employee);
            }
        }
        class Employee
        {
            public string Name { get; set; }
            public string Position { get; set; }

            public Employee(string name, string position)
            {
                Name = name;
                Position = position;
            }
            public void infoEmployee(List<Employee> employees)
            {
                foreach(var emp in employees)
                {
                    Console.WriteLine($"Name: {emp.Name}, Position: {emp.Position}");
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
