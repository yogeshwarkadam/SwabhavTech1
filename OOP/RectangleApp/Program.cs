using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 10;
            Rectangle big;
            big = new Rectangle();

            big.width = 100;
            big.height = 50;

            int areaOfBig = big.CalculateArea();

            Console.WriteLine("width of big rectangle :" + big.width);
            Console.WriteLine("height of big rectangle :" + big.height);
            Console.WriteLine("area of rectangle :" + areaOfBig);
            Console.ReadLine();

        }
    }
}
