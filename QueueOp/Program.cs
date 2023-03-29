using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // queue.Dequeue();
            Console.WriteLine($"total elements {queue.Count}");
            Console.WriteLine($"first element in the queue {queue.Peek()}");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
