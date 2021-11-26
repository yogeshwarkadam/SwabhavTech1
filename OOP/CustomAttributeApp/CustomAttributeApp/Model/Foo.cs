using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeApp.Model
{
    class Foo
    {
        [NeedToRefactor]
        public void M1()
        {
            Console.WriteLine("method 1");
        }
        public void M2()
        {
            Console.WriteLine("method 2");
        }
        [NeedToRefactor]
        public void M3()
        {
            Console.WriteLine("method 3");
        }
        [NeedToRefactor]
        public void M4()
        {
            Console.WriteLine("method 4");
        }



    }
}
