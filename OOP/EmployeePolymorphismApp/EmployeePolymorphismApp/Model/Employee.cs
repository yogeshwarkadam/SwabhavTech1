using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    abstract class Employee
    {
        int _empno;
        string _name;
        double _basicSalary;
       

        public Employee(int pempno,string pname,double pbasicsalary)
        {
            _empno = pempno;
            _name = pname;
            _basicSalary = pbasicsalary;
        }
        public abstract void Calculate();
        public int empno
        {
            get
            {
                return _empno;
            }
        }
        public string empname
        {
            get
            {
                return _name;
            }
        }
        public double basicSalary
        {
            get
            {
                return _basicSalary;
            }
        }


    }
}
