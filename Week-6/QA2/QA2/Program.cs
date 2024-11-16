using System;

namespace QA2
{
    class Program
    {
        class Employee
        {
            public string Name { get; set; }
            public string Position { get; set; }
            public Department Department { get; private set; }

            public Employee(string name, string position)
            {
                Name = name;
                Position = position;
                Department = null; 
            }

            public void SetDepartment(Department department)
            {
                Department = department; 
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Çalışan: {Name}, Pozisyon: {Position}");
                if (Department != null)
                {
                    Console.WriteLine($"Departman: {Department.Name}, Lokasyon: {Department.Location}");
                }
                else
                {
                    Console.WriteLine("Departman atanmadı.");
                }
            }
        }


        class Department
        {
            public string Name { get; set; }
            public string Location { get; set; }

            public Department(string name, string location)
            {
                Name = name;
                Location = location;
            }
        }

        static void Main(string[] args)
        {

            Department department1 = new Department("Yazılım", "İstanbul");
            Department department2 = new Department("Pazarlama", "Samsun");

            Employee employee1 = new Employee("Omer", "Yazılım Geliştirici");
            Employee employee2 = new Employee("Emir", "Pazarlama Uzmanı");

            employee1.SetDepartment(department1);
            employee2.SetDepartment(department2);

            employee1.DisplayInfo();
            employee2.DisplayInfo();

            Console.ReadLine();
        }
    }
}
