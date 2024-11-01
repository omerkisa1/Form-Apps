using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    class Program
    {
        class RentACar
        {
            string plate;
            decimal rentPaymentPerDay;
            bool available;

            public RentACar(string plate, decimal rentPaymentPerDay)
            {
                this.plate = plate;
                this.rentPaymentPerDay = rentPaymentPerDay;
                this.available = true;
            }

            public bool RentCar()
            {
                if (available)
                {
                    available = false;
                    Console.WriteLine($"The car with plate {plate} has been rented.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"The car with plate {plate} is already rented.");
                    return false;
                }
            }

            public bool ReturnCar()
            {
                if (!available)
                {
                    available = true;
                    Console.WriteLine($"The car with plate {plate} has been returned.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"The car with plate {plate} was not rented.");
                    return false;
                }
            }
        }

        static void Main(string[] args)
        {
            RentACar car1 = new RentACar("34ABC123", 100);

   
            car1.RentCar(); 
            car1.RentCar(); 
            
            car1.ReturnCar(); 
            car1.ReturnCar(); 
        }
    }
}
