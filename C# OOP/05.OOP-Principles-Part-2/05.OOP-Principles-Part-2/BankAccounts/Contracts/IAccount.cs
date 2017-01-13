using BankAccounts.Customers;

namespace BankAccounts.Contracts
{
    public interface IAccount
    {
        Customer Customer { get; }
        decimal Balance { get; }
        decimal InterestRate { get; }
        decimal InterestForPeriod(int months);
    }
}
