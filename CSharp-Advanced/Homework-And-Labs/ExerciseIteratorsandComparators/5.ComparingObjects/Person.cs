﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _5.ComparingObjects
{
    class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo( Person other)
        {
            int result = 1;
            if (other != null)
            {
               result = this.Name.CompareTo(other.Name);
            }
            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }
            if (result == 0)
            {
                result = this.Town.CompareTo(other.Town);
            }
            return result;
        }
    }
}
