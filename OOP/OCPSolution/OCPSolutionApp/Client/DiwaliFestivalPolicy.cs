using OCPSolutionApp.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolutionApp.Client
{
    public class DiwaliFestivalPolicy:IFestivalPolicy
    {
        public double CalculateRate()
        {
            return 0.08;
        }
    }
}
