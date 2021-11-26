using RectangleEncapsulationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1;
            r1 = new Rectangle();
            r1.SetWidth(150);
            Console.WriteLine("you enter width : " +r1.GetWidth());



            r1.SetHeight(30);
            Console.WriteLine("you enter height : " + r1.GetHeight());
            Console.ReadLine();

        }
    }
}
