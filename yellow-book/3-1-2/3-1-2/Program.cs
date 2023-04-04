using System;

class MethodDemo
{
    static void silly(int i)
    {
        Console.WriteLine("i is: " + i);
    }

    static int silly2(int i)
    {
        return i;
    }

    public static void Main()
    {
        silly(101);
        silly(500);

        Console.WriteLine("i is: " + silly2(1));
    }
}
