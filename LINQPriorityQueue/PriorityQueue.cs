using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PriorityQueue.Abstract;

namespace LINQPriorityQueue
{

    public class PriorityQueue<T> : IPriorityQueue<T>
    {
        private List<Tuple<uint, T>> _allPriorities;

        public PriorityQueue()
        {
            _allPriorities = new List<Tuple<uint, T>>();
        }

        public int Count => _allPriorities.Count;

        public T Dequeue()
        {
            Tuple<uint, T> priority = _allPriorities.OrderBy(p => p.Item1).ToList().First();

            _allPriorities.Remove(priority);

            return priority.Item2;
        }

        public void Enqueue(uint priority, T item)
        {
            _allPriorities.Add(new Tuple<uint, T>(priority, item));
        }

        public void RunForeach()
        {
            _allPriorities.ForEach(p => Console.WriteLine($"the item: {p.Item2} have the priority {p.Item1}"));
        }
    }
}
