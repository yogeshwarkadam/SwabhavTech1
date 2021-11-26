using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TodoSerialisationDeserialisation
{
    class Program
    {
      

        static void Main(string[] args) 
        {
            List<string> todolist = new List<string>();
            string path = @"D:\SwabhavTech\todoSerialise.txt";
            Stream stream = File.Open(path, FileMode.OpenOrCreate);
            BinaryFormatter bin = new BinaryFormatter();
            bool continueLooping = true;
            while(continueLooping)
            {
                Console.WriteLine("1.Display");
                Console.WriteLine("2.Add");
                Console.WriteLine("3.remove");
                Console.WriteLine("4.exit");
                Console.WriteLine();
                Console.WriteLine("choice: ");
                

               
                int choiceInt = Convert.ToInt32(Console.ReadLine());
                if (choiceInt == 1)
                {

                    var dlist = (List<string>)bin.Deserialize(stream);
                    if (dlist.Count == 0)
                    {
                        Console.WriteLine("No item in the List");
                    }
                    foreach (var a in dlist)
                    {


                        Console.WriteLine(a);

                    }
                    


                }
                else if (choiceInt == 2)
                {
                    Console.WriteLine("Enter item to add:");
                    string newItem = Console.ReadLine();
                    todolist.Add(newItem);
                    bin.Serialize(stream, todolist);
                }
                else if (choiceInt == 3)
                {
                    Console.WriteLine("Enter item to Remove: ");
                    string newItem = Console.ReadLine();
                    todolist.Remove(newItem);
                }
                else
                {
                    Console.WriteLine("Thank you for using this App...");
                    continueLooping = false;
                }

            }
            stream.Close();
            Console.ReadLine();

        }
    }
}
