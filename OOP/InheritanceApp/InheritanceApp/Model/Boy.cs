using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    class Boy:Man
    {
        public void play()
        {
            Console.WriteLine("\nboy is playing");
        }
        public override void jump()
        {
            Console.WriteLine("boy is jumping");
        }

        public void walk()
        {
            Console.WriteLine("boy is walking");
        }
        public void read()
        {
            Console.WriteLine("boy is reading");
        }
    }
}
