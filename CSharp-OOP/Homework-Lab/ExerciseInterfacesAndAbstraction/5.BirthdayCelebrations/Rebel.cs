using System;
using System.Collections.Generic;
using System.Text;

namespace _5.BirthdayCelebrations
{
    public class Rebel : IBuyer
    {
        private int foodCount = 0;
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food
        {
            get
            {
                return this.foodCount;
            }
            set
            {
                foodCount = value;
            }
        }

        public void BuyFood()
        {
            foodCount += 5;
            
        }
    }
}
