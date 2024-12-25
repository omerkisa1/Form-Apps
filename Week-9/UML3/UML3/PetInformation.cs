using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3
{
    public class PetInformation
    {
        public List<string> Traits { get; set; } = new List<string>();
        public List<Vaccine> Vaccines { get; set; } = new List<Vaccine>();
    }
}
