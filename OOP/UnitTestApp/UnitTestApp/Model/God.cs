using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestApp.Model
{
    [MyUnitTest]
    class God
    {
        [MyUnitTestMethod]
        public bool G1()
        {
            return false;
        }
        [MyUnitTestMethod]
        public bool G2()
        {
            return true;
        }
    }
}
