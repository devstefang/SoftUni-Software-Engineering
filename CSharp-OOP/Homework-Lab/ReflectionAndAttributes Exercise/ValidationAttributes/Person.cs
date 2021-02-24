using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
   public class Person
    {
        [MyRange(12,90)]
        public int Age { get; set; }
        [MyRequired]
        public string FullName { get; set; }
        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

    }
}
