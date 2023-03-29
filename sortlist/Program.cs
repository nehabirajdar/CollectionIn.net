using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList sortedList = new SortedList();
            //sortedList.Add(91, "IND");
            //sortedList.Add(65, "AUS");
            //sortedList.Add(1, "USA");
            //sortedList.Add(2, "UK");

            ////sortedList.Remove(2);
            //sortedList.Add(20, "Test");
            //Console.WriteLine("Total elements " + sortedList.Count);

            SortedList sortedList = new SortedList();
            sortedList.Add(9434738332, "Pooja");
            sortedList.Add(7452748356, "Pratik");
            sortedList.Add(9364872542, "Ganesh");
            sortedList.Add(7534435864, "Shraddha");

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

        }


    }
}
