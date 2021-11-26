using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Model
{
    class Boy : IManner, IEmotion
    {
        public void cry()
        {
            Console.WriteLine("boy is crying");
        }

        public void depart()
        {
            Console.WriteLine("boy is depart");
        }

        public void Laugh()
        {
            Console.WriteLine("boy is laughing");
        }

        public void wish()
        {
            Console.WriteLine("boy is wishing");
        }
    }
}
