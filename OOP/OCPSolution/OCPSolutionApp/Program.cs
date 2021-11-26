using OCPSolutionApp.Client;
using OCPSolutionApp.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposite fd1 = new FixedDeposite("yogeshwar", 5000, 5, new DiwaliFestivalPolicy());
            Console.WriteLine("simple interest: " + fd1.SimpleInterest());
            Console.ReadLine();
        }
    }
}
