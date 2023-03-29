using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortedList
{
    public class Program
    {
        static void Main(string[] args)
        {

            Sortedlist sortedList = new Sortedlist();
                sortedList.Add(91, "IND");
                sortedList.Add(65, "AUS");
                sortedList.Add(1, "USA");
                sortedList.Add(2, "UK");

            //sortedList.Remove(2);
            sortedList.Add(20, "Test");
                Console.WriteLine("Total elements " + sortedList.Count);
                foreach (DictionaryEntry item in sortedList)
                {
                    Console.WriteLine(item.Key + "  " + item.Value);
                }
            }


        }

    internal class Sortedlist
    {
    }
}
