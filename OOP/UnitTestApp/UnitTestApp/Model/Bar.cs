using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestApp.Model
{
    [MyUnitTest]
    class Bar
    {
        [MyUnitTestMethod]
        public bool B1()
        {
            return false;
        }
        public bool B2()
        {
            return false;
        }
        public bool B3()
        {
            return false;
        }

    }
}
