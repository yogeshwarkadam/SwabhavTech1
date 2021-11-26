using RectangleConstructorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("area of anonymous object is : " + new Rectangle(3, 4).calculateArea());
           
            display(new Rectangle(3, 5));
           

            Rectangle[] rectangles = new Rectangle[4];
            Console.WriteLine();

            Console.WriteLine("first rectangle: ");
            rectangles[0] = new Rectangle(9, 5);
            display(rectangles[0]);
            Console.WriteLine();

            Console.WriteLine("second rectangle: ");
            rectangles[1] = new Rectangle(3, 5);
            display(rectangles[1]);
            Console.WriteLine();

            Console.WriteLine("Third Rectangle: ");
            rectangles[2] = new Rectangle(8, 8);
            display(rectangles[2]);
            Console.WriteLine();

            Console.WriteLine("fourth Rectangle: ");
            rectangles[3] = new Rectangle(2, 4);
            display(rectangles[3]);
            Console.ReadLine();
        }

        private static void display(Rectangle r)
        {
            Console.WriteLine("width: "+r.width);
            Console.WriteLine("height: " + r.height);
            Console.WriteLine("Calculated Area: " + r.calculateArea());
        }
    }
}
