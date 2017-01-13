using BankAccounts.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Bank
    {
        private List<Account> myAccounts;

        public Bank (List<Account> myAccounts)
        {
            this.myAccounts = myAccounts;
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
