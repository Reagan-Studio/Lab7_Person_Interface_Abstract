using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Person_Interface_Abstract
{
    class PassengerCar : Transport, INalog
    {
        public double Power { get; set; }
        public PassengerCar() : base()
        {
            Power = 0;
        }
        public PassengerCar(Person owner, double cost, string name, double capacity, double power) : base(owner, cost, name, capacity)
        {
            Power = power;
        }

        public double Tax()
        {
            if (Power < 100)
            {
                return Power * 2.5;
            }
            else if (Power >= 100 & Power <= 150)
            {
                return Power * 3.5;
            }
            else if (Power > 150 & Power <= 200)
            {
                return Power * 5;
            }
            else if (Power > 200 & Power <= 250)
            {
                return Power * 7.5;
            }
            else if (Power > 250 & Power <= 410)
            {
                return Power * 15;
            }
            else
            {
                return Power * 300;
            }
        }
    }
}
