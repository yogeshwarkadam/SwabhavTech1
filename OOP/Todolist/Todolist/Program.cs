using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            List<string> todolist = new List<string>();
            Console.WriteLine("Welcome to TodoApp");
            bool continueLooping = true;
            while (continueLooping)
            {
                Console.WriteLine();
                Console.WriteLine("1.Display");
                Console.WriteLine("2.Add");
                Console.WriteLine("3.Remove");
                Console.WriteLine("4.Exit");
                Console.WriteLine();
                Console.WriteLine("Choice:");
                int choiceInt = Convert.ToInt32(Console.ReadLine());
                if (choiceInt == 1)
                {
                    if (todolist.Count == 0)
                    {
                        Console.WriteLine("No item in the List");
                    }
                    foreach (var a in todolist)
                    {
                        
                      
                        Console.WriteLine(a);
                    }
                }
                else if (choiceInt == 2)
                {
                    Console.WriteLine("Enter item to add:");
                    string newItem = Console.ReadLine();
                    todolist.Add(newItem);
                }
                else if(choiceInt == 3)
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

            Console.ReadLine();
        }    
    }
}
