using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestApp.Model
{
    [AttributeUsage(AttributeTargets.All)]
    class MyUnitTest:Attribute
    {
        private string name { get; set; }
      

    }
}
