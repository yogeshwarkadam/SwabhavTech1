using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDelegateApp
{
    delegate void DMathOperations(int num1,int num2);
    class Program
    {
        private int num1;
        private int num2;

        static void Main(string[] args)
        {
            {
                DMathOperations f1;
                f1 = Add;
                f1 += Subtract;
                f1 += Modulus;
                f1 += Division;
                f1(5, 3);

                Console.ReadKey();
            }

        public int Add(int num)
        {
            num = num1 + num2;
            return num;
            Console.WriteLine("add is: " + num);
        }
        public int Substract(int num)
        {
            num = num1 - num2;
            return num;
            Console.WriteLine("substract is: " + num);
        }
        public int Division(int num)
        {
            num = num1 / num2;
            return num;
            Console.WriteLine("division is: " + num);
        }
    }
}
