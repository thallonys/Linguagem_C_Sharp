using System;

namespace ex4
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            // crate two Account objects
            Account account1 = new Account("Jane Green");
            Account account2 = new Account("John Blue");

            // display initial value of name for eacch Account
            Console.WriteLine("account 1 name is: {0}", account1.Name);
            Console.WriteLine("account 2 name is: {0}", account2.Name);
        }
    }
}