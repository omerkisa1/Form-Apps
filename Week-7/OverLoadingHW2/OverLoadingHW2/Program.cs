using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingHW2
{
    class Program
    {
        const double PI = 3.14;
        public int Area(int a)
        {
            return a*a;
        }
        public int Area(int a, int b)
        {
            return a*b;
        }
        public double Area(double r)
        {
            return PI*r*r;
        }

        static void Main(string[] args)
        {
        }
    }
}
