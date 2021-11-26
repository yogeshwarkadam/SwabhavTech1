using RectangleEncapsulationApp2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1;
            r1 = new Rectangle();
            r1.setWidthAndHeight (5,12);
            Console.WriteLine("r1 width:" + r1.GetWidth());
            Console.WriteLine("r1 height:" + r1.GetHeight());
            Console.WriteLine("r1 area:" + r1.CalculateArea());
            Console.WriteLine("area of anonymous object is: " + new Rectangle().CalculateArea());
           
            Console.ReadLine();
        }
    }
}
