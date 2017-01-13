using BankAccounts.Contracts;
using BankAccounts.Customers;

namespace BankAccounts.Accounts
{
    public class DepositAccount : Account, IAccount, IDeposit, IWithdraw
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal InterestForPeriod(int months)
        {
            decimal result = 0;
            if(this.Balance <= 1000 && this.Balance >= 0)
            {
                result = 0;
            }
            else
            {
                result = InterestRate * months;
            }

            return result;
        }
    }
}
