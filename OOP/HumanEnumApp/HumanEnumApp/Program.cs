using HumanEnumApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanEnumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("yogesh", 166, 63, GenderType.Male);
            PrintDetails(h1);

            h1.Eat();
            PrintDetails(h1);

            h1.Workout();
            PrintDetails(h1);
            Console.ReadLine();

        }
        static void PrintDetails(Human h1)
        {
            Console.WriteLine("Name: " + h1.GetHumanName());
            Console.WriteLine("Height : " + h1.GetHumanHeight() + "cm");
            Console.WriteLine("Weight : " + h1.GetHumanWeight() + "kg");
            Console.WriteLine("Gender: " + h1.GetHumanGender());
            Console.WriteLine();
           
        }

    }

}
