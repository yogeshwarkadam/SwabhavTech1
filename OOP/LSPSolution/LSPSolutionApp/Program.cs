using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 30);
            Console.WriteLine("area of Rectangle: "+ r.CalculateArea());

            Square r1 = new Square(200);
            Console.WriteLine("Area of Square: "+ r1.CalculateArea());
        }
    }
}
