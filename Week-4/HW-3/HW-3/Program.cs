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
            bool avaliable;
            public RentACar(string plate, decimal rentPaymentPerDay)
            {
                this.plate = plate;
                this.rentPaymentPerDay = rentPaymentPerDay;
                this.avaliable = true;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
