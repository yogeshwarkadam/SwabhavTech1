using LSPViolationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 20);
            WhenHeightChangedWidthShouldNotBeChange(r);

            Rectangle r1 = new Square(10);
            WhenHeightChangedWidthShouldNotBeChange(r1);
            Console.ReadLine();

        }
        private static void WhenHeightChangedWidthShouldNotBeChange(Rectangle rectangle)
        {
            int before = rectangle.width;
            rectangle.height = rectangle.height + 10;
            int after = rectangle.width;
            Console.WriteLine("\nIs width changed:{0} ",before != after);
            Console.WriteLine("before changing height width is:{0} ",before );
            Console.WriteLine("after changing height width is:{0} ",before );
           
        }
    }
}
