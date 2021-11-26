using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp2.Model
{
    class Rectangle
    {
        private int width;
        private int height;


        public double CalculateArea()
        {
            double area = height * width;
            return area;
        }


        public int Validate(int dimension)
        {
            if (dimension <= 100 && dimension >= 1)
            {
                return dimension;

            }
          
            else if(dimension < 1)
            {
                return 1;

            }
            else if(dimension > 100)
            {
                return 100;
            }
            return dimension;
        }

        public void setWidthAndHeight(int widthParameter,int heightParameter)
        {
            width = Validate(widthParameter);
            height = Validate(heightParameter);
        }

        public int GetWidth()
        {
            return width;
        }
       
        
        public int GetHeight()
        {
            return height;
        }
    }
}
