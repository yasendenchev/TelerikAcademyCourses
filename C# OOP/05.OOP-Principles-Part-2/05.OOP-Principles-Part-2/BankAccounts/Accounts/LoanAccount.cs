using BankAccounts.Contracts;
using BankAccounts.Customers;

namespace BankAccounts.Accounts
{
    public class LoanAccount : Account, IAccount, IDeposit
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal InterestForPeriod(int months)
        {
            decimal result = 0;
            if (this.Customer.CustomerType.ToString() == "Individual")
            {
                if (months > 3)
                {
                    result = InterestRate * (months - 3);
                }
            }

            else if (this.Customer.CustomerType.ToString() == "Company")
            {
                if (months > 2)
                {
                    result = InterestRate * (months - 2);
                }
            }
            return result;
        }
    }
}
