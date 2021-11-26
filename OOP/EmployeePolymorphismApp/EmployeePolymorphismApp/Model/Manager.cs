using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class Manager:Employee
    {
        public double HRA;
        public double TA;
        public double DA;
      
        public Manager(int pempno, string pname, double pbasicsalary) : base(pempno, pname, pbasicsalary)
        {

        }

        public override void Calculate()
        {
            HRA = base.basicSalary * 50 / 100;
           
            TA = base.basicSalary * 40 / 100;
            DA = base.basicSalary * 30 / 100;
            Console.WriteLine("HRA:" + HRA + "\nTA:" + TA +"\nDA"+DA) ;
            
        }
    }
}
