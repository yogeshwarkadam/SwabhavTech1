using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolationApp.Model
{
    class Square:Rectangle
    {
         int _side;

        public Square(int side ) :base(side,side)
        {

        }
        public override int width
        {
            set
            {
                _width = value;
                _height = value;
            }
        }
        public override int height
        {
            set
            {
                _height = value;
                _width = value;
            }
        }
        public int CalculateArea()
        {
            return height * height;
        }
    }
}
