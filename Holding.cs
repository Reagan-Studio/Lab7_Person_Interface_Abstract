using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Person_Interface_Abstract
{
    abstract class Holding : IComparable<Holding>
    {
        public Person Owner { get; set; }
        public double Cost { get; set; }
        public int CompareTo(Holding obj)
        {
            return obj.Cost.CompareTo(Cost);
        }


    }
}
