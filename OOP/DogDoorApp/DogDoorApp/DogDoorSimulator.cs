using DogDoorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp
{
    class DogDoorSimulator
    {
        

        static void Main(string[] args)
        {
            DogDoor d1 = new DogDoor();
            Remote r1 = new Remote(d1);
            Console.WriteLine("\nfido bark to go outside...");
            r1.PressButton();
            Console.WriteLine("\nfido has gon outside...");
            r1.PressButton();
            Console.WriteLine("\nfido's all done...");
            r1.PressButton();
            Console.WriteLine("\nfido back inside...");
            r1.PressButton();
            Console.ReadLine();

        }
    }
}
