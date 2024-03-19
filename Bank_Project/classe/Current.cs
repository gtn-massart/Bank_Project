
using System.Runtime.CompilerServices;

namespace Bank_Project.classe
{
    internal class Current
    {
        // Champs
        private double _balance;
        private double _creditLine;

        // Propriétés
        public Person Owner { get; set; }
        public string Number { get; set; }        
        public double Balance
        {
            get 
            { 
                return _balance; 
            }
            private set
            {
                if (value < -CreditLine)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _balance = value;
                }
            }
        }

        public double CreditLine
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

        // Surcharge opérateur +
        public static double operator +(double a, Current b)
        {
            return a + ((b.Balance > 0) ? b.Balance : 0);
        }

        // Méthode publiques
        public void Withdraw(double amount)
        {
            if(amount <= 0)
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
    }
}
