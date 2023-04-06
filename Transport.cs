using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Person_Interface_Abstract
{
    class Transport : Holding
    {
        public string Name { get; set; }
        public double Capacity { get; set; }

        public Transport()
        {
            Owner = new Person();
            Cost = 0;
            Capacity = 0;
            Name = "";
        }
        public Transport(Person owner, double cost, string name, double capacity)
        {
            Owner = owner;
            Cost = cost;
            Capacity = capacity;
            Name = name;
        }
        
    }
}
