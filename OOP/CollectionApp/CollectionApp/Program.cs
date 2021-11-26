using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            //CaseStudy2();
            Console.ReadLine();
        }

        private static void CaseStudy1()
        {
            ArrayList basket = new ArrayList();
            basket.Add(new LineItem("shoes", 2000, 2));
            basket.Add(new LineItem("mobile", 12000, 1));
            basket.Add(new LineItem("shirt", 200, 3));
            basket.Add("Hello AurionPro");



            foreach (LineItem item in basket)
            {
                Console.WriteLine("\nproduct name:" + item.GetName);
                Console.WriteLine("product price:" + item.GetPrice);
                Console.WriteLine("product quantity:" + item.GetQuantity);
                Console.WriteLine("product Total price:" + item.TotalPrice());
            }

        }

        private static void CaseStudy2()
        {
            List<LineItem> basket = new List<LineItem>();
            basket.Add(new LineItem("shoes", 2000, 2));
            basket.Add(new LineItem("mobile", 12000, 1));
            basket.Add(new LineItem("shirt", 200, 3));
           

            double FinalPrice = 0;
            foreach (LineItem item in basket)
            {
                Console.WriteLine("\nproduct name:" + item.GetName);
                Console.WriteLine("product price:" + item.GetPrice);
                Console.WriteLine("product quantity:" + item.GetQuantity);
                Console.WriteLine("product Total price:" + item.TotalPrice());
                FinalPrice += item.TotalPrice();

            }
            Console.WriteLine("final price:"+ FinalPrice);



        }
    }
}
