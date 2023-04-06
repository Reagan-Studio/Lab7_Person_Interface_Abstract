using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Person_Interface_Abstract
{
    class PersonHourlyPay : PersonFixPay, ICLlabel, INalog
    {
        public int WorkedHours { get; set; }


        public PersonHourlyPay() : base()
        {
            WorkedHours = 0;
        }
        public PersonHourlyPay(string surname, string name, char sex, double payment, double reward, int work_hours) : base(surname, name, sex, payment, reward)
        {
            WorkedHours = work_hours;
        }
        public PersonHourlyPay(string surname, string name, DateTime bthDate, char sex, double payment, double reward, int work_hours) : base(surname, name, bthDate, sex, payment, reward)
        {
            WorkedHours = work_hours;
        }
        public PersonHourlyPay(PersonHourlyPay person) : base(person)
        {
            WorkedHours = person.WorkedHours;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Введите кол-во отработанных часов:");
            WorkedHours = int.Parse(Console.ReadLine());
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Кол-во отработанных часов: {WorkedHours}");
        }


        public override double FullTotalPayment()
        {
            return Payment * WorkedHours * (1 + (Reward / 100));
        }


    }
}
