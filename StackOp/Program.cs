using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            stack.Pop();
            stack.Pop();
            Console.WriteLine($"top element in the stack {stack.Peek()}");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }



        }


    }
    }

