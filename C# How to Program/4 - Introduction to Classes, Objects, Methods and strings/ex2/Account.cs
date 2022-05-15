// Fig. 4.6: Accounts.cs
// Account class that replaces public methods SetName
// and GetName witha public Name property.

class Account
{
    private string name; // instance variable

    // method that sets the account name in the object
    
    // property to get and set the name instance variable
    public string Name
    {
        get // returns the corresponding instance variable´s value
        {
            return name; // returns the value of name to the client code
        }
        set // assigns a new value to the correspondig instance variable
        {
            name = value; // value is implicitly declared and initialized
        }
    }
}