using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Person_Interface_Abstract
{
    class Horse : Transport, INalog
    {
        public int Age { get; set; }
        public double Weight { get; set; }

        public Horse() : base()
        {
            Age = 0;
            Weight = 0;
        }
        public Horse(Person owner, double cost, string name, double capacity, int age, double weight):base(owner, cost, name, 0)
        {
            Age = age;
            Weight = weight;
        }

        public double Tax()
        {
            return 200;
        }
    }

}
