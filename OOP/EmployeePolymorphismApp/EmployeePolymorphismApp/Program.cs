using EmployeePolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer d1 = new Developer(101, "yogeshwar", 20000);
            SalarySlip(d1);
            d1.Calculate();
           
            Manager m1 = new Manager(102, "vinod", 30000);
            SalarySlip(m1);
            m1.Calculate();
           
            Accountant a1 = new Accountant(103, "john", 40000);
            SalarySlip(a1);
            a1.Calculate();
           
            Console.ReadLine();


        }
        public static void SalarySlip(Employee em1)
        {
            Console.WriteLine("--------------------Salary Sleep------------------");
            Console.WriteLine("employee post:"+ em1.GetType().Name);
            Console.WriteLine("employee no:"+em1.empno);
            Console.WriteLine("employee name:"+em1.empname);
            Console.WriteLine("employee basic salary:"+em1.basicSalary);
           
      
        }
    }
}
