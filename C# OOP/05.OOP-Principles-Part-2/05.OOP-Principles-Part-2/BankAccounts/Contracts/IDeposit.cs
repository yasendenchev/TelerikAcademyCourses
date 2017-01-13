using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Contracts
{
    interface IDeposit
    {
        void DepositMoney(decimal amount);
    }
}
