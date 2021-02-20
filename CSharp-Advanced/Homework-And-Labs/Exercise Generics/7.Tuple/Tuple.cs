using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Tuple
{
    class Tuple<TKey,TValue,TThirdValue>
    {
        public TKey FirstItem { get; set; }
        public TValue SecondItem { get; set; }
        public TThirdValue ThirdItem { get; set; }
        public Tuple(TKey firstItem, TValue secondItem, TThirdValue thirdItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
            ThirdItem = thirdItem;
        }
        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}
