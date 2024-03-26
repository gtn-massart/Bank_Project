

namespace Bank_Project.classe
{
    public class Current : Account
    {
        // Champs
        private double _creditLine;

        // Propriété  
        public override double CreditLine
        {
            get 
            {
                return _creditLine; 
            }
        }

        public Current(string number, Person owner) : base(number, owner)
        {

        }

        public Current(string number, Person owner, double balance) : base(number, owner, balance)
        {

        }

        public Current(Person owner, string number, double creditLine, double balance = 0) : base(owner, number, creditLine, balance)
        {

        }

        // Méthode publiques
        public override void Withdraw(double amount)
        {
            if( Balance - amount >= -_creditLine)
            {
                base.Withdraw(amount);
            }
        }

        protected override double CalculationBenefit()
        {
            if (Balance >= 0)
            {
                return Balance * (3.0 / 100);
            }
            return Balance * (9.75 / 100);
        }
    }
}
