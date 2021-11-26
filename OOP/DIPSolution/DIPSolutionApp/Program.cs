using DIPSolutionApp.HighLevelModule;
using DIPSolutionApp.LowLevelModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator cal = new TaxCalculator(new FileLogger());
            Console.WriteLine(cal.Calculate(15, 8));
            Console.WriteLine(cal.Calculate(20, 0));
            Console.ReadLine();
        }
    }
}
