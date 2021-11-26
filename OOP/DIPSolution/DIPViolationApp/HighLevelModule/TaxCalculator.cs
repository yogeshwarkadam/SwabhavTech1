using DIPViolationApp.LowLevelModule;
using DIPViolationApp.HighLevelModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.HighLevelModule
{
    class TaxCalculator
    {
        private LogPolicyType _policy;
        public TaxCalculator(LogPolicyType logPolicy)
        {
            this._policy = logPolicy;

            if (_policy == LogPolicyType.DB)
            {
                Console.WriteLine(new DBLogger().WriteLine());
            }
            else
            {
                Console.WriteLine(new FileLogger().WriteLine());
            }
        }

        public int Calculate(int value1, int value2)
        {
            int result = 0;
            try
            {
                result = value1 / value2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
