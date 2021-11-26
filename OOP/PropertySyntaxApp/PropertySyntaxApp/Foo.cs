using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySyntaxApp
{
    class Foo
    {
        private int _bar;

        public int Bar
        {
            get
            {
                return _bar;
            }
            set
            {
                if (value > 0)
                {
                    _bar = value;
                }
            }
        }
       
        public int GetBar()
        {
            return _bar;
        }
    }
}
