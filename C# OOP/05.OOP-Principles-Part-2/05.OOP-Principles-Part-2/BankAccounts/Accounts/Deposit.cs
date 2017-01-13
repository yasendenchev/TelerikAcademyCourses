using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Customers;
using BankAccounts.Contracts;

namespace BankAccounts.Accounts
{
    public class Deposit : Account, IAccount, IDeposit, IWithdraw
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
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
