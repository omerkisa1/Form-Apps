using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    class Program
    {
        class Phone
        {
            string name, surname, phoneNumber;
            
            public Phone(string name, string surname, string phoneNumber)
            {
                this.name = name;
                this.surname = surname;
                this.phoneNumber = phoneNumber;
            }
            public void GetContactInfo()
            {
                Console.WriteLine($"Name: {name} {surname}, Phone Number: {phoneNumber}");
            }

        }
        static void Main(string[] args)
        {
            Phone phone1 = new Phone("Omer", "Kisa", "XXXXXXXXXXXX");
            phone1.GetContactInfo();
        }
    }
}
