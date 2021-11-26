using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Model
{
    class Man:IManner
    {
        public void cry()
        {
            Console.WriteLine("man is crying");
        }

        public void depart()
        {
            Console.WriteLine("man is depart");
        }

        public void Laugh()
        {
            Console.WriteLine("man is laughing");
        }

        public void wish()
        {
            Console.WriteLine("man is wishing");
        }
    }
}
