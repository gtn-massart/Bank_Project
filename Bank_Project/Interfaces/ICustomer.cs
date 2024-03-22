

namespace Bank_Project.Interfaces
{
    internal interface ICustomer
    {
        double Solde { get; }
        void Deposit(double amount);
        void Withdraw(double amount);
    }
}
