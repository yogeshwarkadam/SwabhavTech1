using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.radius = 5;
            circle.color = "red";
            double areaOfCircle = circle.AreaOfCircle();
            Console.WriteLine("the radius of circle is : " + circle.radius);
            Console.WriteLine("the color of circle is : " + circle.color);
            Console.WriteLine("Area of circle is : " +areaOfCircle);
           
            double perimeterOfCircle = circle.PerimeterOfCircle();
            Console.WriteLine("Perimeter of circle is : " + perimeterOfCircle);
             Console.ReadLine();
        }

    }
}
