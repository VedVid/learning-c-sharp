using System;

class BreakContinue
{
    public static void Main()
    {
        int do_while_counter = 0;
        Console.WriteLine("do - while loop starts...");
        do
        {
            do_while_counter++;
            if (do_while_counter % 2 == 0)
            {
                continue;
            }
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
            if (while_counter > 5)
            {
                break;
            }
            Console.WriteLine(while_counter);
        }
        Console.WriteLine("while loop ends.");
    }
}