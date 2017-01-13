using BankAccounts.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Customers;


namespace BankAccounts
{
    class Startup
    {
        static void Main(string[] args)
        {
            //Customers
            var ivan = new Individual("Ivan");
            var gosho = new Individual("Gosho");
            var pesho = new Individual("Pesho");
            var sHolidays = new Company("Sunshine Holidays ltd.");
            var albena = new Company("Albena AD");
            var telerik = new Company("Telerik AD");           

            //Individuals' accounts
            var ivanLoan = new LoanAccount(ivan, 10, 2);
            var peshoDeposit = new DepositAccount(pesho, 30, 1);
            var goshoMortgage = new MortgageAccount(gosho, 50, 3);
            
            //Companies' accounts
            var sHolidaysLoan = new LoanAccount(sHolidays, 10, 2);
            var telerikMortgage = new MortgageAccount(telerik, 100, 5);
            var albenaDeposit = new DepositAccount(albena, 20, 4);
            
            var accounts = new List<Account>();
            accounts.Add(ivanLoan);
            accounts.Add(goshoMortgage);
            accounts.Add(peshoDeposit);
            accounts.Add(sHolidaysLoan);
            accounts.Add(telerikMortgage);
            accounts.Add(albenaDeposit);
            
            var myBank = new Bank(accounts);
            Console.WriteLine("People/companies with accounts in our bank:");
            foreach (var account in myBank.MyAccounts)
            {
                Console.WriteLine(account.Customer.Name);
            }
            Console.WriteLine();
            //Printing info for all of the individuals' accounts
            Console.WriteLine("IVAN'S LOAN ACCOUNT:");
            Console.WriteLine($"Ivan has balance of ${ivanLoan.Balance} in his loan account.");
            ivanLoan.DepositMoney(90);
            Console.WriteLine($"He deposited $100 and now the account has balance of ${ivanLoan.Balance}.");
            Console.WriteLine($"The interest of Ivan's loan account for period of 20 months will be {ivanLoan.InterestForPeriod(20)}%, because the account has no interest for the first 3 months.");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("GOSHO'S MORTGAGE ACCOUNT:");
            Console.WriteLine($"Gosho has balance of ${goshoMortgage.Balance} in his account.");
            goshoMortgage.DepositMoney(100);
            Console.WriteLine($"He deposited $100 and now he has balance of ${ivanLoan.Balance}.");
            Console.WriteLine($"The interest of his account for period of 20 months will be {ivanLoan.InterestForPeriod(10)}%, because the account has no interest for the first 6 months.");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("PESHO'S DEPOSIT ACCOUNT:");
            Console.WriteLine($"Pesho has balance of ${peshoDeposit.Balance} in his account.");
            peshoDeposit.DepositMoney(100);
            Console.WriteLine($"He deposited $100 and now the account has balance of ${peshoDeposit.Balance}.");
            peshoDeposit.Withdraw(100);
            Console.WriteLine($"He withdrew $100 and now the account has balance of ${peshoDeposit.Balance}.");
            Console.WriteLine($"The interest of his account for period of 20 months will be {peshoDeposit.InterestForPeriod(10)}%, because the account' balance is more than $1000.");
            Console.WriteLine("------------------------------------");


            //Printing info for all of the companies' accounts.
            Console.WriteLine("SUNSHINE HOLIDAYS EAD LOAN ACCOUNT:");
            Console.WriteLine($"The company has balance of ${sHolidaysLoan.Balance} in its loan account.");
            sHolidaysLoan.DepositMoney(90);
            Console.WriteLine($"The company deposited $100 and now the account has balance of ${sHolidaysLoan.Balance}.");
            Console.WriteLine($"The interest of the company's loan account for period of 20 months will be {sHolidaysLoan.InterestForPeriod(20)}%, because the account has no interest for the first 2 months.");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("TELERIK MORTGAGE ACCOUNT:");
            Console.WriteLine($"The company has balance of ${telerikMortgage.Balance} in its account.");
            telerikMortgage.DepositMoney(100);
            Console.WriteLine($"The company deposited $100 and now the account has balance of ${telerikMortgage.Balance}.");
            Console.WriteLine($"The interest of the company's account for period of 20 months will be {telerikMortgage.InterestForPeriod(10)}%, because the account has interest of 1/2 for the first 12 months.");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("ALBENA DEPOSIT ACCOUNT:");
            Console.WriteLine($"The company has balance of ${albenaDeposit.Balance} in its account.");
            albenaDeposit.DepositMoney(100);
            Console.WriteLine($"The company deposited $100 and now the account has balance of ${albenaDeposit.Balance}.");
            albenaDeposit.Withdraw(100);
            Console.WriteLine($"The company withdrew $100 and now the account has balance of ${peshoDeposit.Balance}");
            Console.WriteLine($"The interest of the company account for period of 20 months will be {albenaDeposit.InterestForPeriod(10)}%, because the account's balance is more than $1000.");
            Console.WriteLine("------------------------------------");
        }
    }
}

