using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Animal dog = new Animal { Type = "Dog", Breed = "Golden Retriever", Carnivore = true };

            Owner owner = new Owner { Name = "Alice" };

 
            Pet pet = new Pet
            {
                Name = "Buddy",
                Age = 3,
                Owner = owner,
                PetInfo = new PetInformation
                {
                    Traits = new List<string> { "Friendly", "Loyal" },
                    Vaccines = new List<Vaccine>
                {
                    new Vaccine { Name = "Rabies", Type = "Viral" }
                }
                },
                Type = dog 
            };

 
            pet.Feed();
            Console.WriteLine($"Is {pet.Name} herbivore? {pet.IsHerbivore()}");
            Console.WriteLine($"{pet.Name}'s owner is {pet.Owner.Name}.");

            Console.ReadKey();
        }
    }

}
