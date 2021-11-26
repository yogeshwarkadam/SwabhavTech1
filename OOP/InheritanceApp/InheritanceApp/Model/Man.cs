using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    class Man
    {
        public void walk()
        {
            Console.WriteLine("man is walking");
        }
        public void play()
        {
            Console.WriteLine("man is playing");
        }
        public void read()
        {
            Console.WriteLine("man is reading");
        }
        public virtual void jump()
        {

        }
      
    }
}
