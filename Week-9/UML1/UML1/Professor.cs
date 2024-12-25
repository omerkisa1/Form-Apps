using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1
{
    class Professor: Person
    {
        public int salary { get; set; }
        protected int staffNumber { get; set; }

        private int yearsOfService { get; set; }
        public int numberOfClasses { get; set; }

        private List<Student> supervisedStudents;

        public Professor()
        {
            supervisedStudents = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if (!supervisedStudents.Contains(student))
            {
                supervisedStudents.Add(student);
                Console.WriteLine($"{student.name} is now supervised by Professor {this.name}.");
            }
            else
            {
                Console.WriteLine($"{student.name} is already supervised by Professor {this.name}.");
            }
        }

        public void RemoveStudent(Student student)
        {
            if (supervisedStudents.Contains(student))
            {
                supervisedStudents.Remove(student);
                Console.WriteLine($"{student.name} is no longer supervised by Professor {this.name}.");
            }
            else
            {
                Console.WriteLine($"{student.name} is not supervised by Professor {this.name}.");
            }
        }

        public List<Student> GetSupervisedStudents()
        {
            return supervisedStudents;
        }
    }
}
