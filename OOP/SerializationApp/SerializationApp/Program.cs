using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bucketlist = new List<string>();

            bucketlist.Add("yogeshwar");
            bucketlist.Add("vallabh");
            bucketlist.Add("arti");
            bucketlist.Add("advait");
            string path = @"D:\SwabhavTech\Serialise.txt";

            Stream stream = File.Open(path, FileMode.Create);
            BinaryFormatter bin = new BinaryFormatter();
            bin.Serialize(stream,bucketlist );
            

            //string path = @"D:\SwabhavTech\Serialise.txt";

            //string newItem = Console.ReadLine();          
            // FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            // BinaryFormatter formater = new BinaryFormatter();


            //// Console.ForegroundColor = System.ConsoleColor.Red;
            // //onsole.WriteLine("file saved in: " + path);
             stream.Close();
            Console.ReadLine();

        }
    }
}
