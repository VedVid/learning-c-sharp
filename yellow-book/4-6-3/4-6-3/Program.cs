// Partial example, does not compile.

public static bool AccountAllowed(decimal income, int age)
{
    if ((income >= 10000) && (age >= 18))
    {
        return true;
    }
    else
    {
        return false;
    }
}

/* This is interesting example. Since static methods are called by class
   and not by instance, you can check if user is allowed to create an account
   before even trying to create account.
   If it were non-static method, you would need to create an instance of Account
   first, and then check if user data fits the bill.
*/
