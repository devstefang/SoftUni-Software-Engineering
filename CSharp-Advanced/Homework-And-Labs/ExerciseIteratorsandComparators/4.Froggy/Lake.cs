using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _4.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> items;

        public Lake(List<int>items)
        {
            this.items = items;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i+=2)
            {
                yield return this.items[i];
            }
            for (int i = items.Count - 1; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.items[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
