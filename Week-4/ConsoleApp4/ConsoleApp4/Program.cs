using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {

        class Student
        {
            string name, surname;
            private int note;

            public Student(string name, string surname)
            {
                this.name = name;
                this.surname = surname;

            }
            int getNote()
            {
                return this.note;
            }
            void setNote(int x )
            {
                if (x<0 || x > 100)
                {
                    Console.WriteLine("Notes has to be betwwen 0-100");
                    return;
                }
                this.note = x;
            }
            void fullName()
            {
                Console.WriteLine("Name: " + this.name + " Surname: " + this.surname);
            }
        }


        static void Main(string[] args)
        {
            Student student = new Student("Omer", "Kisa");

        }
    }
}
