using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleEncapsulationApp.Model
{
    class Circle
    {
        private int radius;
        private string color;

        public void SetRadius(int pradius)
        {
            if (pradius < 1)
            {
                radius = 1;
            }
            else if (pradius > 10)
            {
                radius = 10;
            }
            else
            {
                radius = pradius;
            }


        }
        public int GetRadius()
        {
            return radius;
        }
        public void SetColor(string pcolor)
        {
            if (pcolor == "red" || pcolor == "green" || pcolor == "blue")
            {
                color = pcolor;
            }
            else
            {
                color = "red";

            }
        }
        public string GetColor()
        {
            return color;
        }
    }
}
