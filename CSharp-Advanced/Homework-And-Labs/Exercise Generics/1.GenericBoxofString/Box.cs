using System;
using System.Collections.Generic;
using System.Text;

namespace _1.GenericBoxofString
{
     class Box<T> where T: IComparable
    {
        public Box(List<T> values)
        {
            Values = values;
        }
        public List<T> Values { get; set; }

        public void Swap(int firstIndex, int secondIndex)
        {
            T tempIndex = Values[firstIndex];
            Values[firstIndex] = Values[secondIndex];
            Values[secondIndex] = tempIndex;
        }
        public int GreaterElementsCount(List<T> values , T value)
        {
            int count = 0;
            int sum = 0;
            foreach (T currValue in values)
            {
                if (value.CompareTo(currValue) < 0)
                {
                    count++;
                }
            }
            return count;
        }
        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (var value in Values)
        //    {
        //        sb.AppendLine($"{value.GetType()}: {value}");
        //    }
        //    return sb.ToString().TrimEnd();
        //}
    }
}
