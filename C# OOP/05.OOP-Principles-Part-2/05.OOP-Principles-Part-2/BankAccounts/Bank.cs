using BankAccounts.Accounts;
using BankAccounts.Contracts;
using BankAccounts.Customers;
using System.Collections.Generic;

namespace BankAccounts
{
    public class Bank : IBank
    {
        private List<Account> myAccounts;


        public Bank()
        {

        }

        public Bank(List<Account> myAccounts)
        {
            this.MyAccounts = myAccounts;
        }


        public List<Account> MyAccounts
        {
            get
            {
                return this.myAccounts;
            }
            set
            {
                this.myAccounts = value;
            }
        }
    }
}
