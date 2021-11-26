using DIPSolutionApp.CommonModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionApp.LowLevelModule
{
    class FileLogger:ILogger
    {
        public string log()
        {
            string message = "logging to DB";
            return message;
        }
    }
}
