using System;
using System.Collections.Generic;

namespace LINQPriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<string> priorityQueue = new PriorityQueue<string>();
            priorityQueue.Enqueue(3, "A");
            priorityQueue.Enqueue(1, "B");
            priorityQueue.Enqueue(2, "C");
            priorityQueue.Enqueue(1, "D");


            Console.WriteLine(priorityQueue.Dequeue());
            priorityQueue.RunForeach();
        }
    }
}
