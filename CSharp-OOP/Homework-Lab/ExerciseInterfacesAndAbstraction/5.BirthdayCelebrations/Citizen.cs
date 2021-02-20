using System;
using System.Collections.Generic;
using System.Text;

namespace _5.BirthdayCelebrations
{
    public class Citizen : IIdentifiable,IBirthable,IBuyer
    {
        private int foodCount = 0;
        public Citizen(string name,int age, string id,string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthdate;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string BirthDate { get; set; }

        public int Food
        {
            get
            {
                return this.foodCount;
            }
            set
            {
                this.foodCount = value;
            }
        }

        public void BuyFood()
        {
            foodCount += 10;
        }
    }
}
