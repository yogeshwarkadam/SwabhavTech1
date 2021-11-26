using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserSecurity.Model;

namespace UserSecurity
{
    class Program
    {
        static void Main(string[] args)
        {
            SecurityService secure = new SecurityService();
            secure.AddUser("1001", "yogesh", "kadam", "yogeshkadam99@gmail.com", "123123");
            secure.AddUser("1002", "yogeshwar", "kadam", "yogeshkadam99@gmail.com", "4545");
            secure.Login("1002", "455");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
