using System;

public interface IAccount
{
    void PayInFunds(decimal amount);

    bool WithdrawFunds(decimal amount);

    decimal GetBalance();
}

public class CustomerAccount : IAccount
{
    // Originally private, but child can't change
    // inherited members that are private.
    protected decimal balance = 0;

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

        accounts[0] = new CustomerAccount();
        accounts[0].PayInFunds(50);
        accounts[0].WithdrawFunds(20);
        Console.WriteLine("Balance: " + accounts[0].GetBalance());

        accounts[1] = new BabyAccount();
        accounts[1].PayInFunds(30);
        accounts[1].WithdrawFunds(20);
        accounts[1].WithdrawFunds(10);
        Console.WriteLine("Balance: " + accounts[1].GetBalance());
    }
}
