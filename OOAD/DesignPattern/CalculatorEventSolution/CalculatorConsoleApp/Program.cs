using CalculatorLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            calc.OnAdditionOperationComplete += DiplayDetails;
            calc.Add(15, 30);

            calc.OnSubtractionOperationComplete += DiplayDetails;
            calc.Subtract(80, 10);
            Console.ReadKey();
        }
        public static void DiplayDetails(string type, int a, int b, double c)
        {
            Console.WriteLine("Type: {0}\nFirst Val : {1}\nSecond Val : {2}\nResult : {3}\n", type, a, b, c);
        }
    }
}
