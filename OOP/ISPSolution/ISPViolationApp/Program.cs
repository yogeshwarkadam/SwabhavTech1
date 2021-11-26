using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker manager = new Manager();
            IWorker robot = new Robot();
            AtTheCafeterial(manager);
            AtTheWorkStation(manager);
            AtTheCafeterial(robot);
            AtTheWorkStation(robot);
        }

        private static void AtTheWorkStation(IWorker worker)
        {
            worker.StartWork();
            worker.StopWork();
        }

        private static void AtTheCafeterial(IWorker worker)
        {
            worker.StartEat();
            worker.StopWork();
        }
    }
}
