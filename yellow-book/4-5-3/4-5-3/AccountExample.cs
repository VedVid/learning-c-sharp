using System;

public class Account
{
    private decimal balance = 0;

    public bool WithdrawFunds(decimal amount)
    {
        if (balance < amount)
        {
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

class AccountExample
{
    public static void Main()
    {
        Account account = new Account();
        account.PayInFunds(50);
        if (account.GetBalance() != 50)
        {
            Console.WriteLine("Pay In test failed");
        }
        else
        {
            Console.WriteLine("Pay In test succeeded");
        }
    }
}
