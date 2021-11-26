using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    class PremiumCustomerDb:CustomerDb
    {
        public override void Delete()
        {
            Console.WriteLine("data deleted");

        }
        public override void Update()
        {
            Console.WriteLine("data updated");

        }

    }
}
