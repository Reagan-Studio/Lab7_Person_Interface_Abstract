using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Person_Interface_Abstract
{
    class Stead : Holding, INalog
    {
        public double Area { get; set; }


        public Stead()
        {
            Owner = new Person();
            Cost = 0;
            Area = 0;
        }
        public Stead(Person owner, double cost, double area)
        {
            Owner = owner;
            Cost = cost;
            Area = area;
        }

        public double Tax()
        {
            return Cost*0.3;
        }
    }
}
