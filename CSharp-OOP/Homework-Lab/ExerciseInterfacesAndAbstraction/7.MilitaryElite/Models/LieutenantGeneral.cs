using System;
using System.Collections.Generic;
using System.Text;

namespace _7.MilitaryElite
{
    public class LieutenantGeneral : Private,ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
        }

        public ICollection<Private> Privates { get; set; }
    }
}
