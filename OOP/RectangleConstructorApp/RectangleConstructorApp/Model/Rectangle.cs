using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp.Model
{
    class Rectangle
    {
        public int width;
        public int height;

        public Rectangle(int pwidth,int pheight) //constructor
        {
            width = pwidth;
            height = pheight;
        }
        public double calculateArea()
        {
            double area = width * height;
            return area;
        }

    }
}
