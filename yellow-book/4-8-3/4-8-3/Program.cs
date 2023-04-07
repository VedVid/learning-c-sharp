using System;

/* Looks like interafaces work a tad different that
 * I thought.
 * You _first_ declare interface, and then _later_ you implement
 * class that fits the interface.
*/

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

class Bank
{
    public static void Main()
    {
        IAccount account = new CustomerAccount();
        account.PayInFunds(50);
        Console.WriteLine("Balance: " + account.GetBalance());
    }
}
