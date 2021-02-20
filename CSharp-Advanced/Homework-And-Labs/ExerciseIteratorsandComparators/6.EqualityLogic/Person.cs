﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _6.EqualityLogic
{
    class Person : IComparable<Person>
    {
        private SortedSet<Person> sortedSet;
        private HashSet<Person> hashSet;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            sortedSet = new SortedSet<Person>();
            hashSet = new HashSet<Person>();
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(Person other)
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
            return result;
        }
        public override bool Equals(object obj)
        {
            if (obj != null && obj is Person other)
            {
                return this.Name == other.Name && this.Age == other.Age;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode();
        }
    }
}
