using System;

public interface IAccount
{
    void PayInFunds(decimal amount);

    bool WithdrawFunds(decimal amount);

    decimal GetBalance();
}

public class CustomerAccount: IAccount
{
    private decimal balance = 0;

    public bool WithdrawFunds(decimal amount)
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

// But it is code duplication, only difference between BabyAccount
// and CustomerAccount is behaviour of WithdrawFunds method.
public class BabyAccount: IAccount
{
    private decimal balance = 0;
    private static decimal max_withdraw = 10;

    public bool WithdrawFunds(decimal amount)
    {
        if (balance < amount || amount > max_withdraw)
        {
            Console.WriteLine("You tried to withdraw too much!");
            return false;
        }
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
