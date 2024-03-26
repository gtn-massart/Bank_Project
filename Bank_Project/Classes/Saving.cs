using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project.classe
{
    public class Saving : Account
    {
        public DateTime DateLastWithdrawal { get; set; }
        public Saving(string number, Person owner) : base(number, owner)
        {

        }

        public Saving(string number, Person owner, double balance) : base(number, owner, balance)
        {

        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);

            DateLastWithdrawal = DateTime.Now;  
        }


        protected override double CalculationBenefit()
        {
            return Balance * (4.5 / 100);
        }
    }
}
