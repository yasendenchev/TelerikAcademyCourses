using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Utils;

namespace BankAccounts.Contracts
{
    interface ICustomer
    {
        string Name { get; }
        CustomerType CustomerType { get; }
    }
}
