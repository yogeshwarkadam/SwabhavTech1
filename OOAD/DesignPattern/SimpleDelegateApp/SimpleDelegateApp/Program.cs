using System;

namespace SimpleDelagateApp
{
    delegate void DPrintMessage(String name);
 class Program
    {
        static void Main(string[] args)
        {
            DPrintMessage f1;
            f1 = PrintHello;
            f1("yogesh");
            f1 = PrintGoodBye;
            f1("shivam");
            Console.WriteLine();

            MessageWizard(f1);
            MessageWizard(PrintHello);
            MessageWizard(PrintGoodBye);
            Console.WriteLine();

            Console.WriteLine("\n");
            DPrintMessage f2 = PrintHello;
            f2 += PrintGoodBye;
            f2 += PrintHello;
            f2 += PrintGoodBye;
            f2("Swabav Tech");
            Console.ReadLine();
        }
        static void PrintHello(string name)
        {
            Console.WriteLine("hello says {0} ", name);
        }
        static void PrintGoodBye(string name)
        {
            Console.WriteLine("GoodBye saya {0} ", name);
        }
        static void PrintFoo()
        {

        }
        static void MessageWizard(DPrintMessage f)
        {
            Console.WriteLine("inside MessageWizard");
            f("CHAMP");
        }


    }
}
