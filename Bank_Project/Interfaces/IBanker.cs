using Bank_Project.classe;

namespace Bank_Project.Interfaces
{
    internal interface IBanker : ICustomer
    {
        void ApplyBenefit();
        Person Owner { get; }
        string Number { get; }
    }
}
