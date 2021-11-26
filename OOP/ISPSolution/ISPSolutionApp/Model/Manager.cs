using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    class Manager:IWorkableEatable
    {
        public void StartWork()
        {
            Console.WriteLine("manager is starting work");
        }
        public void StopWork()
        {
            Console.WriteLine("manager is stoping work");
        }
        public void StartEat()
        {
            Console.WriteLine("manager is starting eat");
        }
        public void StopEat()
        {
            Console.WriteLine("manager is stoping eat");
        }
    }
}
