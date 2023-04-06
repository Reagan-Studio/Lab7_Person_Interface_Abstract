using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Person_Interface_Abstract
{
    class SmallShip : Transport, INalog
    {
        public int Paddle { get; set; }
        public double Power { get; set; }

        public SmallShip():base()
        {
            Paddle = 0;
            Power = 0;
        }
        public SmallShip(Person owner, double cost, string name, double capacity, int paddle, double power):base(owner, cost, name, capacity)
        {
            Paddle = paddle;
            Power = power;
        }

        public double Tax()
        {
            if (Power <= 100)
            {
                return Power*10;
            }
            else if(Power >100 & Power <= 300)
            {
                return Power * 20;
            }
            else
            {
                return Power*200;
            }
        }
    }
}
