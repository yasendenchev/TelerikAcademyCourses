using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Accounts;
using BankAccounts.Contracts;
using BankAccounts.Customers;

namespace BankAccounts.Accounts
{
    public class Mortgage : Account, IDeposit
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
