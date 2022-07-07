// Fig. 4.8: Accounts.cs
// Account class with a constructor that initializes an Accounts's name.

class Account
{
    public string Name { get; set; } // auto-implemented property

    // constructor sets the Name property to parameter accountName's value
    public Account(string accountName) // constructor name is class name
    {
        Name = accountName;
    }

}