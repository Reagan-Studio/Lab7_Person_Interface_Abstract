using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Person_Interface_Abstract
{
    class PersonFixPay : Person, ICLlabel, INalog
    {
        public double Payment { get; set; }

        public double Reward { get; set; }


        public PersonFixPay() : base()
        {
            Payment = 0;
            Reward = 0;
        }
        public PersonFixPay(string surname, string name, char sex, double payment, double reward) : base(surname, name, sex)
        {
            Payment = payment;
            Reward = reward;
        }
        public PersonFixPay(string surname, string name, DateTime bthDate, char sex, double payment, double reward) : base(surname, name, bthDate, sex)
        {
            Payment = payment;
            Reward = reward;
        }
        public PersonFixPay(PersonFixPay person) : base(person)
        {
            Payment = person.Payment;
            Reward = person.Reward;
        }
        public PersonFixPay(Person person, double payment, double reward) : base(person)
        {
            Payment = payment;
            Reward= reward;
        }


        public override void Input()
        {
            base.Input();
            Console.WriteLine("Введите зарплату:");
            Payment = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент премии:");
            Reward = double.Parse(Console.ReadLine());
        }


        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Зарплата: {Payment} \nПроцент премии: {Reward}");
        }


        public override string ToString()
        {
            return base.ToString() + $"\nЗарплата {Payment} \nПроцент премии {Reward}";
        }


        public virtual double FullTotalPayment()
        {
            return Payment * (1 + (Reward / 100));
        }


        public double Tax()
        {
            return FullTotalPayment() * 0.13;
        }


        public double TaxTotalPayment()
        {
            return FullTotalPayment() - Tax();
        }


    }
}
