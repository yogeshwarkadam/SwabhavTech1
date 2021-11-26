using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountToStringEqualityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            Console.ReadLine();

        }

        private static void CaseStudy1()
        {
            Account a1 = new Account(101, "yogesh", 12000);
            Console.WriteLine(a1);
            Console.WriteLine(a1.ToString());

            
        }

        private static void CaseStudy2()
        {
            Account a2 = new Account(102, "vinod", 15000);
            Account a3 = new Account(103, "prashant", 200000);
            Console.WriteLine("\n HashCode of account 2: "+a2.GetHashCode());
            Console.WriteLine(" HashCode of account 3: " + a3.GetHashCode());
            Console.WriteLine(a2 == a3);
            Console.WriteLine(a2.Equals(a3));
        }
    }
}
