using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    class Robot:IWorkable
    {
        public void StartWork()
        {
            Console.WriteLine("robot is start to work");
        }
        public void StopWork()
        {
            Console.WriteLine("robot is stop to work");
        }

    }
}
