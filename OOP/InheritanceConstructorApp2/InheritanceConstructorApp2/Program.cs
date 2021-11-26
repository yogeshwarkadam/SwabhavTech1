using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceConstructorApp2.Model;

namespace InheritanceConstructorApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
        }

        private static void CaseStudy1()
        {
            Child c1 = new Child();
            Console.WriteLine(c1.Foo);
            Child c2 = new Child(150);
            Console.WriteLine(c2.Foo);
            Console.ReadLine();
        }
    }
}
