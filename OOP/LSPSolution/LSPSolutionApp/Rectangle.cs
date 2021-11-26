using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionApp
{
    class Rectangle:IPolygon
    {
        protected int _width;
        protected int _height;

        public Rectangle (int width , int height)
        {
            this. _width = width;
            this._height = height;
        }
        virtual public int width
        {
            get
            {
                return width;
            }
            set
            {
                _width = value;
            }
        }
        virtual public int height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
        public int CalculateArea()
        {
            return
                height * width;
        }
    }
}
