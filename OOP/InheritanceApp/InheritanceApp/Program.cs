using InheritanceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Casestudy1();
            // Casestudy2();
            // Casestudy3();
            //Casestudy4();
            CaseStudy5();
            Console.ReadLine();
        }
        private static void Casestudy1()
        {
            Man m1 = new Man();
            m1.walk();
            m1.play();
            m1.read();
           
        }
        private static void Casestudy2()
        {
            Boy b1 = new Boy();
            b1.play();
            b1.jump();
            b1.walk();
            b1.read();

        }
        private static void Casestudy3()
        {
            Man x = new Boy();
            x.read();
            x.play();
            x.walk();
            x.jump();


        }
        private static void Casestudy4()
        {
            AtThePark(new Man());
            AtThePark(new Kid());
            AtThePark(new Infant());
            AtThePark(new Boy());


        }
        private static void CaseStudy5()
        {
            object x;
            x = 12;
            Console.WriteLine(x.GetType());
            x = 0.5f;
            Console.WriteLine(x.GetType());
            x = "i am student";
            Console.WriteLine(x.GetType());
            x = new Man();
            Console.WriteLine(x.GetType());

        }
        private static void AtThePark(Man x)
        {
            Console.WriteLine("atThePark");
        }
        
    }
}
