using BankAccounts.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Customers
{
    public class Company : Customer
    {
        public Company(string name, CustomerType customerType) : base(name, CustomerType.Company)
        {
        }
    }
}
