

using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account Acc1 = new Account(101, "yogesh", 1000);
            Console.WriteLine(Acc1.GetCount());

            Account Acc2 = new Account(102, "arti",2000);
            Console.WriteLine(Acc2.GetCount());

            Account Acc3 = new Account(103, "vallabh",3000);
            Console.WriteLine(Acc3.GetCount());
            Console.ReadLine();
        }
    }
}
