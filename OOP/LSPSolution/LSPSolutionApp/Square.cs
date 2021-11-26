using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionApp
{
    class Square:IPolygon
    {
        private int _sides;

        public  Square(int side)
        {
            _sides = side;
        }
        public int Side
        {
            set
            {
                _sides = value;
            }
            get
            {
                return _sides;
            }
        }
        public int CalculateArea()
        {
            return _sides * _sides;
        }
    }
}
