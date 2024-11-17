using System;
using System.Collections.Generic;

namespace AssociationHW4
{
    class Program
    {
        class Parent
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public List<Child> Children { get; set; }

            public Parent(string name, int age)
            {
                Name = name;
                Age = age;
                Children = new List<Child>();
            }

            public void AddChild(Child child)
            {
                if (!Children.Contains(child))
                {
                    Children.Add(child);
                    child.Parent = this; 
                }
            }

            public override string ToString()
            {
                return $"Parent Name: {Name}, Age: {Age}, Number of Children: {Children.Count}";
            }
        }

        class Child
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Parent Parent { get; set; }

            public Child(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public override string ToString()
            {
                return $"Child Name: {Name}, Age: {Age}, Parent: {(Parent != null ? Parent.Name : "No Parent")}";
            }
        }

        static void Main(string[] args)
        {
          
            Parent parent1 = new Parent("John", 40);
            Parent parent2 = new Parent("Emma", 38);

            
            Child child1 = new Child("Sophia", 10);
            Child child2 = new Child("Liam", 8);
            Child child3 = new Child("Olivia", 12);

          
            parent1.AddChild(child1);
            parent1.AddChild(child2);
            parent2.AddChild(child3);

         
            Console.WriteLine(parent1);
            Console.WriteLine(parent2);
            Console.WriteLine(child1);
            Console.WriteLine(child2);
            Console.WriteLine(child3);

            Console.ReadLine();
        }
    }
}
