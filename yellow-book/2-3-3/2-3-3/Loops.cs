using System;

class Loops
{
    public static void Main()
    {
        int do_while_counter = 0;
        Console.WriteLine("do - while loop starts...");
        do
        {
            do_while_counter++;
            Console.WriteLine(do_while_counter);
        }
        while (do_while_counter < 10);
        Console.WriteLine("do - while loop ends.");

        Console.WriteLine();

        Console.WriteLine("while loop starts...");
        int while_counter = 0;
        while (while_counter < 10)
        {
            while_counter++;
            Console.WriteLine(while_counter);
        }
        Console.WriteLine("while loop ends.");

        Console.WriteLine();

        Console.WriteLine("for loop starts...");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("for loop ends.");
    }
}