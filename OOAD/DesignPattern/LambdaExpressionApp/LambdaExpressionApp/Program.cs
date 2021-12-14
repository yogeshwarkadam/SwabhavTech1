using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printHowdy = (n) => Console.WriteLine("Howdy says " + n);
            printHowdy("yogesh");

            Action<string, string> printFullName = (fn, ln) => Console.WriteLine("first name is {0} last name is {1}" ,fn, ln);
            printFullName("yogesh", "kadam");

            Func<int, int, long> calculateRectArea = (w, h) => w * h;
            Console.WriteLine("result of area calculation: " + calculateRectArea(5,6));

            Predicate<string> isLongName = (name) => name.Length > 8;
            Console.WriteLine(isLongName("AKshay"));
            string userName = "Swabhav Techlabs";
            Console.WriteLine("is {0} a long name? {1} ", userName, isLongName(userName));
            Console.ReadLine();

        }
    }
}
