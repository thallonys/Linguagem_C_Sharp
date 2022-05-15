// Fig. 4.12: AccountTest.cs
// Reading and writing monetary amounts with Account objects.
using System;

namespace ex5
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            // crate two Account objects
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", -7.53m);

            // display initial balance of each object
            Console.WriteLine("{0}'s balance: {1}", account1.Name, account1.Balance);
            Console.WriteLine("{0}'s balance: {1}", account2.Name, account2.Balance);

            // prompt for then read input
            Console.Write("\nEnter deposit amount for account1: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("adding {0} to account1 balance\n", depositAmount);
            account1.Deposit(depositAmount); // add to account1's balance

            // display balances
            Console.WriteLine("{0}'s balance: {1}", account1.Name, account1.Balance);
            Console.WriteLine("{0}'s balance: {1}", account2.Name, account2.Balance);

            // prompt for then read input
            Console.Write("\nEnter deposit amount for account2: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("adding {0} to account2 balance\n");
            account2.Deposit(depositAmount); // add to account2's balance

            // display balances
            Console.WriteLine("{0}'s balance: {1}", account1.Name, account1.Balance);
            Console.WriteLine("{0}'s balance: {1}", account2.Name, account2.Balance);
        }
    }
}