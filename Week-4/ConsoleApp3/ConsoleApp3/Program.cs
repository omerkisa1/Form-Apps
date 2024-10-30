using System;

namespace ConsoleApp3
{
    class Program
    {
        class Employee
        {
            private string name;
            private string department;
            private decimal salary;

            public Employee(string name, string department, decimal salary)
            {
                this.name = name;
                this.department = department;
                this.salary = salary;
            }

            public decimal GetSalary()
            {
                return this.salary;
            }

            public void SetSalary(decimal newSalary)
            {
                if (newSalary < 0)
                {
                    Console.WriteLine("You can't set a negative value for salary.");
                    return;
                }
                this.salary = newSalary;
            }

            public void IncreaseSalary(int percentage)
            {
                if (percentage < 0)
                {
                    Console.WriteLine("Percentage increase cannot be negative.");
                    return;
                }
                decimal increaseAmount = (salary * percentage) / 100;
                this.salary += increaseAmount;
            }
        }

        static void Main(string[] args)
        {
            Employee employee = new Employee("Omer", "Software", 1000);

            employee.IncreaseSalary(10); 
            Console.WriteLine("Updated Salary: " + employee.GetSalary());

            employee.SetSalary(1200); 
            Console.WriteLine("New Salary: " + employee.GetSalary());
        }
    }
}
