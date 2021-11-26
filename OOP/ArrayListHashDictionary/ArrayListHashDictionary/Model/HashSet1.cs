using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListHashDictionary.Model
{
    class HashSet1
    {
        HashSet<int> hashset = new HashSet<int>();

        public void Create( int value)
        {
            hashset.Add( value);
        }
        public void Delete(int key)
        {
            hashset.Remove(key);
        }
        public void Read()
        {
            if (hashset.Count == 0)
            {
                Console.WriteLine("no value set");
            }
            else
            {
                foreach (int items in hashset)
                {
                    Console.WriteLine(items);
                }
            }
            Console.WriteLine(" ");
        }
        public void Update(int key, int value)
        {
            hashset.Remove(key);
            hashset.Add(value);

        }
    }
}
