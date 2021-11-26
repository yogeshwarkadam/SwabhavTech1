using InterfaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Man x = new Man();
            Boy y = new Boy();
            atThePartyHall(x);
            atThePartyHall(y);
            //atTheCinemaHall(x);
            atTheCinemaHall(y);
            Console.ReadKey();
             

        }

        private static void atTheCinemaHall(IEmotion obj)
        {
            Console.WriteLine("\nAt the Cinema Hall");
            obj.cry();
            obj.Laugh();
        }

        private static void atThePartyHall(IManner obj)
        {
            Console.WriteLine("\nAt the party");
            obj.wish();
            obj.depart();
        }

      
    }
}
