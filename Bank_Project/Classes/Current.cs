

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
            set 
            {
                if(value >= 0)
                {
                    _creditLine = value;
                }
            }
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
