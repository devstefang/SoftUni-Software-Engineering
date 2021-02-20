using System;
using System.Collections.Generic;
using System.Text;

namespace _5.BirthdayCelebrations
{
   public interface IBuyer
    {
        public string Name { get; set; }
        public int Food { get; }
        void BuyFood();
    }
}
