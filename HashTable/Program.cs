using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(9434738332, "Pooja");
            hashtable.Add(7452748356 ,"Pratik");
            hashtable.Add("Ganesh", 9364872542);
            hashtable.Add(6534435864, "Shraddha");
            hashtable.Add(7232857290, "Prathamesh");
            

            //hashtable.Remove("Ganesh");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"{item.Key} --> {item.Value}");
            }

        }
    }
}
