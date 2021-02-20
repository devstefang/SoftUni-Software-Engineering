using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators  
{
    class Iterators<T> : IEnumerable<T>
    {
        private List<T> items;
        private int index = 0;
        public Iterators(List<T> items)
        {
            this.items = items;
        }
        public Iterators()
        {

        }

        public void Create(List<T> list)
        {
            if (list.Count > 0)
            {
                Iterators<T> listyIterator = new Iterators<T>(list);
            }
            else
            {
                Iterators<T> listyIterator = new Iterators<T>();
            }
        }   
        public bool Move()
        {
            if (index+1< items.Count)
            {
                index++;
                return true;
            }
            return false;
        }
        public void Print()
        {
            try
            {
                Console.WriteLine(this.items[index]);

            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Operation!");
            }

        }
        public bool HasNext()
        {
            if (this.index + 1 < this.items.Count)
            {
                return true;
            }
            return false;
        }
        public void END()
        {
            return;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
