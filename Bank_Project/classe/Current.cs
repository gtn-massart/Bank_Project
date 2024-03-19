
using System.Runtime.CompilerServices;

namespace Bank_Project.classe
{
    internal class Current
    {
        private double _balance;
        private double _creditLine;
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
