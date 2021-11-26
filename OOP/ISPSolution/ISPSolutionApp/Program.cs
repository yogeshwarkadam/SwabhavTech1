using ISPSolutionApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            var robot = new Robot();
            AtTheCafetaria(manager);
            AtTheWorkStation(manager);
            AtTheCafetaria(robot);
            AtTheWorkStation(robot);
            
        }
        public static void AtTheCafetaria(IEtable eatable)
        {
            eatable.StartEat();
            eatable.StopEat();
          

            

        }
        public static void AtTheWorkStation(IWorkable workable)
        {
            Console.WriteLine("AtTheWorkStation: ");
            workable.StartWork();
            workable.StartWork();
        }
    }
}
