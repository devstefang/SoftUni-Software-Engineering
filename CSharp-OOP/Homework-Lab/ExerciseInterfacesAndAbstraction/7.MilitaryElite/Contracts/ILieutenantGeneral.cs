using System;
using System.Collections.Generic;
using System.Text;

namespace _7.MilitaryElite
{
   public interface ILieutenantGeneral
    {
        public ICollection<Private> Privates { get; set; }
    }
}
