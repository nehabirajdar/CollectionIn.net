using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set1 = new HashSet<string>();

            set1.Add("C");
            set1.Add("C++");
            set1.Add("C#");
            set1.Add("Java");
            set1.Add("Ruby");

            HashSet<string> set2 = new HashSet<string>();

            set2.Add("PHP");
            set2.Add("C++");
            set2.Add("Perl");
            set2.Add("Java");

            // union on hastset

             //set1.UnionWith(set2);
             //set1.IntersectWith(set2);
           set1.ExceptWith(set2);
            foreach (string s in set1)
            {
                Console.WriteLine(s);
            }

        }
    }
}
