
namespace Bank_Project.classe
{
    public abstract class Account
    {
        private double _balance;
        private double _creditLine;
        public Person Owner { get; set; }
        public string Number { get; set; }

        public virtual double CreditLine
        {
            get
            {
                return _creditLine; 
            }
            set
            {
                if (value >= 0)
                {
                    _creditLine = value;
                }
            }
        }

        public virtual double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value >= -CreditLine)
                {
                    _balance = value;
                }
            }
        }
        
        public static double operator +(double a, Account b)
        {
            return a + ((b.Balance > 0) ? b.Balance : 0);
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error");
            }
            Balance = Balance - amount;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error");
            }
            Balance = Balance + amount;
        }

        protected abstract double CalculationBenefit();

        public void ApplyBenefit()
        {
            double benefit = CalculationBenefit();
            Balance += benefit;
        }
    }
}
