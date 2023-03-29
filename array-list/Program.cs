using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_list
{
    public class Program


    {
        static void Main(string[] args)
        {

            int[] arr1 = new int[] { 2, 3, 5, 1, 4 };
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(67);
            list.Add(4);
            list.Add(5);
            list.Add(15);


            Console.WriteLine( $"Sorted elements {list.Sort}");





        }
    }
}