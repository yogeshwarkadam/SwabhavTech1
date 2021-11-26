using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
             
        
            Invoice i1 = new Invoice(1,"Solar power invoice",1000,20,10);
            print(i1);
            Console.ReadLine();

        }
        static void print(Invoice i1)
        {
            Console.WriteLine("Invoice id: "+ i1.id) ;
            Console.WriteLine("Invoice description: "+ i1.description) ;
            Console.WriteLine("Invoice amount: "+ i1.amount) ;
            Console.WriteLine("Invoice tax: "+ i1.tax+"%");
            Console.WriteLine("Invoice discount: "+ i1.discount+"%");
            Console.WriteLine("Invoice discounted amount: "+ i1.CalculateDiscount()); 
            Console.WriteLine("Invoice tax amount: "+ i1.CalculateTax());
            Console.WriteLine("Invoice final amount: "+ i1.CalculateFinalAmount());
        }
        
    }
}
