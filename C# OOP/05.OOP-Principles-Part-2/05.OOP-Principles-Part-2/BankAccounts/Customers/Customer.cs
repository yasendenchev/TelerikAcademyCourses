using BankAccounts.Contracts;
using BankAccounts.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Customers
{
    public abstract class Customer : ICustomer
    {
        private string name;
        private readonly CustomerType customerType;

        public Customer(string name, CustomerType customerType)
        {
            this.Name = name;
            this.customerType = customerType;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public CustomerType CustomerType
        {
            get
            {
                return this.customerType;
            }
        }
    }
}
