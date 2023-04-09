using System;

public interface IAccount
{
    void PayInFunds(decimal amount);

    bool WithdrawFunds(decimal amount);

    decimal GetBalance();
}

public class CustomerAccount : IAccount
{
    protected string name;
    protected decimal balance;

    public CustomerAccount(string inName, decimal inBalance)
    {
        name = inName;
        balance = inBalance;
    }

    public virtual bool WithdrawFunds(decimal amount)
    {
        if (balance < amount)
            return false;
        balance -= amount;
        return true;
    }

    public void PayInFunds(decimal amount)
    {
        balance += amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}

public class BabyAccount : CustomerAccount, IAccount
{
    public BabyAccount(string inName, decimal inBalance): base(inName, inBalance)
    {
        // I don't get it. It looks like a normal constructor for me,
        // you set memebers to arguments passed to constructor.
        // The only difference is 'base(inName, inBalance)'.
        // But it does not compile without that part...
        name = inName;
        balance = inBalance;
    }

    public override bool WithdrawFunds(decimal amount)
    {
        if (amount > 10)
        {
            return false;
        }
        return base.WithdrawFunds(amount);
        // This is interesting – it seems to return the value of the "base"
        // (so, parent's?) method, alongside with all its side-effects.
    }
}

class Bank
{
    const int MAX_CUST = 100;

    public static void Main()
    {
        IAccount[] accounts = new IAccount[MAX_CUST];

        accounts[0] = new CustomerAccount("Tomek", 100);
        accounts[0].PayInFunds(50);
        accounts[0].WithdrawFunds(20);
        Console.WriteLine("Balance: " + accounts[0].GetBalance());

        accounts[1] = new BabyAccount("Dziecko", 100);
        accounts[1].PayInFunds(30);
        accounts[1].WithdrawFunds(20);
        accounts[1].WithdrawFunds(10);
        Console.WriteLine("Balance: " + accounts[1].GetBalance());
    }
}
