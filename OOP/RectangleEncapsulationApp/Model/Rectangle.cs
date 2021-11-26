 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp.Model
{
    class Rectangle
    {
        private int width;
        private int height;
      

        public void SetWidth(int pwidth)
        {
            if (pwidth > 100)
            {
                width = 100;
            }
            else
            {
                width = pwidth;
            }
        }

        public int GetWidth()
        {
            return width;
        }
        public void SetHeight(int pheight)
        {
            if (pheight > 50)
            {
                height = 50;
            }
            else
            {
                height = pheight;
            }
        }
        public int GetHeight()
        {
            return height;
        }
    }
}
