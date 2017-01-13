using BankAccounts.Accounts;
using System.Collections.Generic;

namespace BankAccounts.Contracts
{
    interface IBank
    {
        List<Account> MyAccounts { get; }
    }
}
