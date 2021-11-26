using CircleEncapsulationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleEncapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle r1;
            r1 = new Circle();
            r1.SetRadius(15);
            Console.WriteLine("circle radius : " + r1.GetRadius());
            r1.SetColor("blue");
            Console.WriteLine("circle color : " + r1.GetColor());
            Console.ReadLine();
        }
    }
}
