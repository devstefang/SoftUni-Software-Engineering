using System;
using System.Collections.Generic;
using System.Text;

namespace _8.CollectionHierarchy.Models
{
   public interface IAddableRemoveable<T> : IAddable<T>
    {
        void Remove(T item);
    }
}
