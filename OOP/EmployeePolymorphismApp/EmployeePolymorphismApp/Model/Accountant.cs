using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    
   
    class Accountant:Employee
    {
        public double perks;

        public Accountant(int pempno, string pname, double pbasicsalary) : base(pempno, pname, pbasicsalary)
        {

        }
        public override void Calculate()
        {
            perks = base.basicSalary * 30 / 100;
            Console.WriteLine("perks:" + perks);
        }
    }
}
