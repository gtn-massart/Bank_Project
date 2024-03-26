

namespace Bank_Project.Interfaces
{
    internal interface ICustomer
    {
        double Balance { get; }
        void Deposit(double amount);
        void Withdraw(double amount);
    }
}
