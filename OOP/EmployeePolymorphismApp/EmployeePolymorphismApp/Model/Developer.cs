using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class Developer:Employee
    {
        public double PA;
        public double OT;
        public Developer(int pempno, string pname, double pbasicsalary):base(pempno,pname,pbasicsalary)
        {

        }

        public override void Calculate()
        {
            PA = base.basicSalary * 40 / 100;
            OT = base.basicSalary * 30 / 100;
            Console.WriteLine("PA:"+PA);
            Console.WriteLine("OT:"+OT);
        }
    }
}
