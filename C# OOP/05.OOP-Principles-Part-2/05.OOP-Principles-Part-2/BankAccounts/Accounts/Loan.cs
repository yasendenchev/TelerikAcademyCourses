using BankAccounts.Accounts;
using BankAccounts.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Customers;

namespace BankAccounts.Accounts
{
    public class Loan : Account, IAccount, IDeposit
    {
        public Loan(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal InterestForPeriod(int months)
        {
            decimal result;
            if ((this.Customer.CustomerType.ToString() == "Individual" && months <= 3) || (this.Customer.CustomerType.ToString() == "Company" && months <= 2))
            {
                months = 0;
            }
            else
            {
                months = 0;
            }
        }

    }
}
