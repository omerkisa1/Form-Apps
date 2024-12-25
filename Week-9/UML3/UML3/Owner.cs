using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3
{
    public class Owner : Experienced
    {
        public string Name { get; set; }
        public void TrainPet(Pet pet)
        {
            Console.WriteLine($"{Name} is training {pet.Name}.");
        }
    }
}
