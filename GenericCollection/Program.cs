using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };

            List<int> ilist = new List<int>();
                ilist.Add(29);
                ilist.Add(52);
                ilist.Add(13);
            ilist.AddRange(arr1);

            ilist.Remove(52);
            // ilist.RemoveRange(1, 3);

            // ilist.RemoveAt(4);
            //ilist.Clear()
            ilist.Sort();
            Console.WriteLine($"total elements {ilist.Count}");
            Console.WriteLine($"capacity of arraylist {ilist.Capacity}");
            // insert, addrange,removerange,remove, removeat,sort , reverse, -> count ,capacity
            List<string> slist = new List<string>();
                slist.Add("Pune");
                slist.Add("Mumbai");
                //slist.Insert(3,"Music");
            Console.WriteLine($"total elements {slist.Count}");



            foreach (string item in slist)
                {
                    Console.WriteLine(item);
                }
                
                List<double> dlist = new List<double>();
                dlist.Add(45222.787);

                foreach (int i in ilist)
                {
                    Console.WriteLine(i);
                }

                Stack<int> istack = new Stack<int>();

            istack.Push(17);
            istack.Push(27);
            istack.Push(30);

           //istack.Pop();
            //istack.Pop();
            Console.WriteLine($"top element in the stack {istack.Peek()}");
            foreach (var item in istack)
            {
                Console.WriteLine(item);
            }

            Queue<string> squeue = new Queue<string>(); 
            squeue.Enqueue("Ajay");
            squeue.Enqueue("Akash");
            squeue.Enqueue("Kalpana");

            // queue.Dequeue();
            Console.WriteLine($"total elements {squeue.Count}");
            Console.WriteLine($"first element in the queue {squeue.Peek()}");
            foreach (var item in squeue)
            {
                Console.WriteLine(item);
            }
            Dictionary<int, String> dictionary = new Dictionary<int, string>();
            dictionary.Add(91, "IND");
            dictionary.Add(61, "USA");

            dictionary.Remove(61);
            foreach(KeyValuePair<int,String> item in dictionary)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
        }
}
