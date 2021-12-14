using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegateAppV2
{
    delegate void DPrintMessage(string name);
    class Program
    {
        static void Main(string[] args)
        {
            DPrintMessage f1;
            f1 = (n) =>
            {

                Console.WriteLine("inside lamda 1");
                Console.WriteLine("howdy says " + n);
              
            };
            f1("yogeshwar");
            f1 = (n) => Console.WriteLine("ola says: " + n);
            f1("swabhav");
            Console.ReadLine();
        }
    }
}
