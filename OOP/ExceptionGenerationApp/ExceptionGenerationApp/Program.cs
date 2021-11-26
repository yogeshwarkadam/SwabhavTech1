using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionGenerationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnum = Convert.ToInt32(args[0]);
            int secondnum = Convert.ToInt32(args[1]);
           
            int result = firstnum / secondnum;
            Console.WriteLine("{0},{1},{2}",firstnum,secondnum,result);
            Console.WriteLine("end of main");
            Main(args);
            Console.ReadKey();
        }
    }
}
