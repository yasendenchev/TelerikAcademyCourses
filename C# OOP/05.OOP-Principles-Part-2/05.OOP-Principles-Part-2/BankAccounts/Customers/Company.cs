using BankAccounts.Contracts;
using BankAccounts.Utils;

namespace BankAccounts.Customers
{
    public class Company : Customer, ICustomer
    {
        public Company(string name) : base(name, CustomerType.Company)
        {
        }
    }
}
