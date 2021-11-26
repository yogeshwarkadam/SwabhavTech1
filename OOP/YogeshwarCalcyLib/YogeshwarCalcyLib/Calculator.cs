using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YogeshwarCalcyLib
{
   public class Calculator
    {
        public long CubeEvenNumber(int number)
        {
            if (number % 2 ==0)
            {
                return number * number * number;
            }
            return -1;
        }
    }
}
