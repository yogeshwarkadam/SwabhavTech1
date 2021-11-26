using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolationApp.Model
{
    class Rectangle
    {
        protected int _height;
       protected int _width;

        public Rectangle(int height ,int width)
        {
            this._height = height;
            this._width = width;
        }

        public virtual int height
        {
            set
            {
                this._height = value;
            }
            get
            {
                return _height;
            }
        }

        public virtual int width
        {
            set
            {
                this._width = value;
            }
            get
            {
                return _width;
            }
        }
        public int CalculateArea()
        {
            return _height * _width;
        }
    }
}
