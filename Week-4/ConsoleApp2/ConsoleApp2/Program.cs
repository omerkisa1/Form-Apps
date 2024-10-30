using System;

namespace ConsoleApp2
{
    class Program
    {
        class Dikdortgen
        {
            double height;
            double width;

            public double GetHeight()
            {
                return this.height;
            }

            public void SetHeight(double x)
            {
                if (x < 0)
                {
                    Console.WriteLine("You can't set a negative value for height.");
                    return;
                }
                this.height = x;
            }

            public double GetWidth()
            {
                return this.width;
            }

            public void SetWidth(double x)
            {
                if (x < 0)
                {
                    Console.WriteLine("You can't set a negative value for width.");
                    return;
                }
                this.width = x;
            }

            public double CalculateArea()
            {
                return height * width;
            }

            public double CalculatePerimeter()
            {
                return 2 * (height + width);
            }
        }

        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();

            dikdortgen.SetHeight(5);
            dikdortgen.SetWidth(10);

            Console.WriteLine("Height: " + dikdortgen.GetHeight());
            Console.WriteLine("Width: " + dikdortgen.GetWidth());
            Console.WriteLine("Area: " + dikdortgen.CalculateArea());
            Console.WriteLine("Perimeter: " + dikdortgen.CalculatePerimeter());
        }
    }
}
