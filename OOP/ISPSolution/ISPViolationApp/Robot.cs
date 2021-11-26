using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp
{
    class Robot:IWorker
    {
        public void StartWork()
        {
            Console.WriteLine("robot is starting work");
        }
        public void StopWork()
        {
            Console.WriteLine("robot is stoping work");
        }
        public void StartEat()
        {
            throw new Exception("robot cant eat");
        }
        public void StopEat()
        {
            throw new Exception("robot cant eat");
        }
    }
}
