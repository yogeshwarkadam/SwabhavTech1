using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DeserialisationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bucketlist = new List<string>();

            String path = @"D:\SwabhavTech\Serialise.txt";

            Stream stream = File.Open(path, FileMode.Open);
            BinaryFormatter bin = new BinaryFormatter();
            bucketlist = (List<string>)bin.Deserialize(stream);
            Console.WriteLine("Deserialize object: ");
            foreach (var item in bucketlist)
            {
                Console.WriteLine(item);
            }

            // FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            // BinaryFormatter formater = new BinaryFormatter();
            // Student s1 = (Student)formater.Deserialize(stream);
            // Console.ForegroundColor = System.ConsoleColor.Green;
            // Console.WriteLine("id: "+s1.id);
            //Console.WriteLine("name: "+s1.name);
            Console.ReadLine();
        }
    }
}
