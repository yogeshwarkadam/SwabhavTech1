using RectangleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.height = 100;
            r1.width = 50;

            Console.WriteLine("rectangle height: " + r1.height);
            Console.WriteLine("Rectangle width: " + r1.width);
            Console.WriteLine( "Rectangle Area: "+ r1.CalculateArea());
            Console.ReadLine();

        }

       
    }
}
