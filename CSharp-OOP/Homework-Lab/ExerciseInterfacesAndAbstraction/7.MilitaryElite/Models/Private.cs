using System;
using System.Collections.Generic;
using System.Text;

namespace _7.MilitaryElite
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            Salary = salary;
        }

        public decimal Salary { get; set; }
    }
}
