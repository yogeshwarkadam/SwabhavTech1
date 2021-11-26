using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    class ProductDb:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("data created");
        }
        public void Delete()
        {
            Console.WriteLine("data deleted");
        }
        public void Read()
        {
            Console.WriteLine("data readed");
        }
        public void Update()
        {
            Console.WriteLine("data upodated");
        }
    }
}
