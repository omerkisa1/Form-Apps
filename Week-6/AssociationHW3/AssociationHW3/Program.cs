using System;
using System.Collections.Generic;

namespace AssociationHW3
{
    class Program
    {
        class Company
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public List<Employee> Employees { get; set; }

            public Company(string name, string location)
            {
                Name = name;
                Location = location;
                Employees = new List<Employee>();
            }

            public void AddEmployee(Employee employee)
            {
                if (!Employees.Contains(employee))
                {
                    Employees.Add(employee);
                    employee.Company = this;
                }
            }

            public override string ToString()
            {
                return $"Company Name: {Name}, Location: {Location}, Employees: {Employees.Count}";
            }
        }

        class Employee
        {
            public string Name { get; set; }
            public string Salary { get; set; }
            public Company Company { get; set; } 

            public Employee(string name, string salary)
            {
                Name = name;
                Salary = salary;
            }

            public override string ToString()
            {
                return $"Employee Name: {Name}, Salary: {Salary}, Company: {(Company != null ? Company.Name : "No Company")}";
            }
        }

        static void Main(string[] args)
        {
        
            Company company1 = new Company("TechCorp", "New York");
            Company company2 = new Company("DesignWorks", "San Francisco");

       
            Employee emp1 = new Employee("Alice", "5000");
            Employee emp2 = new Employee("Bob", "6000");
            Employee emp3 = new Employee("Charlie", "4500");

 
            company1.AddEmployee(emp1);
            company1.AddEmployee(emp2);
            company2.AddEmployee(emp3);

 
            Console.WriteLine(company1);
            Console.WriteLine(company2);
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
            Console.WriteLine(emp3);
        }
    }
}
