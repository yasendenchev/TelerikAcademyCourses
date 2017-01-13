using BankAccounts.Utils;

namespace BankAccounts.Contracts
{
    interface ICustomer
    {
        string Name { get; }
        CustomerType CustomerType { get; }
    }
}
