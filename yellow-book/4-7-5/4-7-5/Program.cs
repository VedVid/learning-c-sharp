class Account
{
    // Partial example, does not compile.
    public Account(string inName, string inAddress, decimal inBalance)
    {
        string err = "";
        if (SetBalance(inBalance) == false)
            err = err + "Bad balance: " + inBalance;

        if (SetName(inName) == false)
            err = err + "Bad name: " + inName;

        if (SetAddress(inAddress) == false)
            err = err + "Bad addr: " + inAddress;

        if (err != "")
            throw new Exception("Account construction failed. " + err);
    }
}