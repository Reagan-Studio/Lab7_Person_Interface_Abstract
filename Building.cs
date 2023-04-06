using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Person_Interface_Abstract
{
    class Building : Holding, INalog
    {
        public string Address { get; set; }

        public Building()
        {
            Owner = new Person();
            Cost = 0;
            Address = "";
        }
        public Building(Person owner, double cost, string addres)
        {
            Owner=owner;
            Cost=cost;
            Address=addres;
        }


        public double Tax()
        {
            return Cost * 0.001;
        }

    }
}
