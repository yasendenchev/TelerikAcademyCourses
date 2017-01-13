using BankAccounts.Contracts;
using BankAccounts.Customers;

namespace BankAccounts.Accounts
{
    public class MortgageAccount : Account, IDeposit
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
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
                if (months > 6)
                {
                    result = InterestRate * (months - 6);
                }
            }

            else if (this.Customer.CustomerType.ToString() == "Company")
            {
                if (months >= 12)
                {
                    result = (InterestRate / 2) * 12;
                    months -= 12;
                    result += InterestRate * months;
                }
            }
            return result;

        }
    }
}
