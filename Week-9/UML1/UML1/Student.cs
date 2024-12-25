using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1
{
    class Student : Person
    {

        public int StudentNumber { get; set; }
        public int AverageMark { get; set; }


        public bool IsEligibleToEnroll(string courseName)
        {
            if (AverageMark >= 50)
            {
                Console.WriteLine($"{name} is eligible to enroll in {courseName}.");
                return true;
            }
            else
            {
                Console.WriteLine($"{name} is not eligible to enroll in {courseName}.");
                return false;
            }
        }

        public int GetSeminarsTaken()
        {

            return 3; 
        }
    }
}
