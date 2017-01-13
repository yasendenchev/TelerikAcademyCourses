using BankAccounts.Contracts;
using BankAccounts.Customers;

namespace BankAccounts.Accounts
{
    public class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance= balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        public virtual decimal InterestForPeriod(int months)
        {
            decimal result = 0;
            result = this.InterestRate * months;
            return result;
        }
    }
}
