using BankAccounts.Contracts;
using BankAccounts.Utils;


namespace BankAccounts.Customers
{
    public class Individual : Customer, ICustomer
    {
        public Individual(string name) : base(name, CustomerType.Individual)
        {

        }
    }
}
