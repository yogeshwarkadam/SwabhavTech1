using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovableApp.Model;

namespace MovableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable[] movableArray = new IMovable[3];
            movableArray[0] = new Bike();
            movableArray[1] = new Truck();
            movableArray[2] = new Car();
            StartRace(movableArray);
            Console.ReadLine();

        }
        public static void StartRace(IMovable[] movables)
        {
            Console.WriteLine("starting the race");
            foreach (IMovable movable in movables)
            {
                movable.Move();
            }
        }
    }
}
