using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1
{
    class Person
    {
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string emailAddress { get; set; }

        public void purchaseParkingPass()
        {

        }

        public Address Address { get; set; }

        public void SetAddress(Address address)
        {
            if (address != null && address.Validate())
            {
                Address = address;
                Console.WriteLine($"{name} now lives at {address.OutputAsLabel()}.");
            }
            else
            {
                Console.WriteLine("Invalid address provided.");
            }
        }

    }
}
