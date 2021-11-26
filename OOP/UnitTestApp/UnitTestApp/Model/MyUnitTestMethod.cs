using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestApp.Model
{
    [AttributeUsage(AttributeTargets.All)]
    class MyUnitTestMethod: Attribute
    {
        private string name { get; set; }
    }
}
