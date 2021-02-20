using _8.CollectionHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _8.CollectionHierarchy.Contracts
{
    public class AddRemoveCollection<T> : IAddableRemoveable<T>
    {
        private Stack<T> collection;
        public void Add(T item)
        {
            Console.Write($"{collection.Count} ");
            collection.Push(item);
        }

        public void Remove(T item)
        {
            this.collection.Push(item);
        }
    }
}
