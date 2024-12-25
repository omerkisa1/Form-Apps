using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1
{
    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrEmpty(Street) && !string.IsNullOrEmpty(City);
        }

        public string OutputAsLabel()
        {
            return $"{Street}, {City}, {State}, {PostalCode}, {Country}";
        }
    }
}