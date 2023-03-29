using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProg
{
    public class Program
    {
        static void Main(string[] args)
        {


            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            ArrayList list = new ArrayList();
            list.Add(10); // implicit boxing
            list.Add("Pune");
            list.Add(4.5);

            list.Insert(0, "Maharashtra");

            list.AddRange(arr1);
            list.Add(100);
            // list.Remove(4.5);
            // list.RemoveRange(1, 3);

            // list.RemoveAt(4);
            //list.Clear();
            Console.WriteLine($"total elements {list.Count}");
            Console.WriteLine($"capacity of arraylist {list.Capacity}");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }


    }

}