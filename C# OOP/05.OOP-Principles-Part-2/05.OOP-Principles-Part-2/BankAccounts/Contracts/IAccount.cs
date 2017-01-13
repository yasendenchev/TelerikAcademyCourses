using BankAccounts.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Contracts
{
    public interface IAccount
    {
        Customer Customer { get; }
        decimal Balance { get; }
        decimal InterestRate { get; }
    }
}
