using System;

enum EmployeeRole
{
    Manager,
    Developer,
    Designer,
    Tester
}

class SalaryCalculator
{
    public double GetSalary(EmployeeRole role)
    {
        switch (role)
        {
            case EmployeeRole.Manager:
                return 8000.0;
            case EmployeeRole.Developer:
                return 6000.0;
            case EmployeeRole.Designer:
                return 5000.0;
            case EmployeeRole.Tester:
                return 4000.0;
            default:
                return 0.0;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
     
        SalaryCalculator salaryCalculator = new SalaryCalculator();
        Console.WriteLine("Manager Maaşı: " + salaryCalculator.GetSalary(EmployeeRole.Manager) + " TL"); 
        Console.WriteLine("Developer Maaşı: " + salaryCalculator.GetSalary(EmployeeRole.Developer) + " TL"); 
        Console.WriteLine("Designer Maaşı: " + salaryCalculator.GetSalary(EmployeeRole.Designer) + " TL"); 
        Console.WriteLine("Tester Maaşı: " + salaryCalculator.GetSalary(EmployeeRole.Tester) + " TL"); 

        Console.ReadLine();
    }
}
