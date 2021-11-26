using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposite fd1 = new FixedDeposite("yogeshwar", 10000, 5, FestivalType.DIWALI);
            Console.WriteLine("simple interest: "+fd1.SimpleInterest());
            Console.ReadLine();
        }
    }
}
