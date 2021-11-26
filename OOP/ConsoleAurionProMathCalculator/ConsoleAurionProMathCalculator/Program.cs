using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AurionProMathCalculator;

namespace ConsoleAurionProMathCalculator
{
    class Program
    {
        private static IEnumerable<int> evenArrey;

        static void Main(string[] args)
        {
            Model m1 = new Model();
            CaseStudy1(m1);
            CaseStudy2(m1);
            CaseStudy2(m1);

            Console.ReadLine();
        }
        private static void CaseStudy1(Model m1)
        {
            if (m1.CheckPrimeNo(23) == true)
            {
                Console.WriteLine("the number is prime");
            }
            else
            {
                Console.WriteLine("the number is not prime");
            }
        }
        private static void CaseStudy2(Model m1)
        {
            int limit = 45;
            int[] evenArray = m1.GenerateEvenNo(limit);
            Console.WriteLine("even no till {0}",limit);
            foreach (int i in evenArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
        }
        private static void CaseStudy3(Model m1)
        {
            int limit = 50;
            int[] primeArray = m1.GeneratePrimeNo(limit);
            Console.WriteLine("prime NO till {0}", limit);

            foreach (int i in primeArray)
            {
                if (i == 0)
                {
                    break;
                }
                else
                {
                    Console.Write(i + " ");
                }

            }
            Console.WriteLine(" ");
        }
    }
}
