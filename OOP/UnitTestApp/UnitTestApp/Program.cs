using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnitTestApp.Model;

namespace UnitTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            casestudy1();
            
        }

        public static void casestudy1()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyUnitTest>().Count() > 0);
            foreach (var T in types)
            {
                Console.WriteLine(T.Name + " " + " ");
                var methods = T.GetMethods().Where(m => m.GetCustomAttributes<MyUnitTestMethod>().Count() > 0);
                object o = Activator.CreateInstance(T);
                Console.WriteLine("no of methods: {0}",methods.Count());
                foreach (var M in methods)
                {
                    var v = M.Invoke(o, null);
                    if (v.Equals(true))
                    {
                        Console.WriteLine(M.Name + "----pass");
                    }
                    else
                    {
                        Console.WriteLine(M.Name + "----fail");
                    }
                }
                
            }



            Console.ReadLine();
        }
    }
}
