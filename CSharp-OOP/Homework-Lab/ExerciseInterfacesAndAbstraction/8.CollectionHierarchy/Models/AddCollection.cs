using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _8.CollectionHierarchy
{
    public class AddCollection<T> : IAddable<T>
    {
        private ICollection<T> collection;

        public void Add(T item)
        {
            Console.WriteLine(collection.Count);
            this.collection.Add(item);
        }
    }
}
