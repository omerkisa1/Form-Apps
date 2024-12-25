using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3
{
    public class Pet : Animal,Identifiable
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Age { get; set; }
        public Owner Owner { get; set; }
        public Animal Type { get; set; }
        public PetInformation PetInfo { get; set; }

        public void Feed()
        {
            Console.WriteLine($"{Name} is being fed.");
        }

        public bool IsHerbivore()
        {
            return !Type.Carnivore;
        }
    }
}
