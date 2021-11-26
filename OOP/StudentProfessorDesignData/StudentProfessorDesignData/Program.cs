using StudentProfessorDesignData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorDesignData
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p1 = new Professor(101, "Pune", "15/08/2010", 40000);
            Professor p2 = new Professor(102, "Mumbai", "19/09/2010", 60000);
            Student s1 = new Student(103, "Kolhapur", "23/04/2020", "CSE");
            Student s2 = new Student(104, "Ahmednagar", "22/03/2022", "Mech");
            PrintDetails(p1);
            PrintDetails(p2);
            PrintDetails(s1);
            PrintDetails(s2);
        }
        public static void PrintDetails(SalaryEmp p)
        {
            Console.WriteLine("\nid: " + p.id);
            Console.WriteLine("name: " + p.address);
            Console.WriteLine("date of birth: " + p.dateofbirth);
            Console.WriteLine("basic salary: " + p.Basicsalary);
            Console.WriteLine("salary after bonus: " + p.CalcSalary());
        }
        public static void PrintDetails(Student s)
        {
            Console.WriteLine("\nid: " + s.id);
            Console.WriteLine("name: " + s.address);
            Console.WriteLine("date of birth: " + s.dateofbirth);
            Console.WriteLine("branch: " + s.branch);
        }
    }
}
