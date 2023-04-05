using System;

class SwitchCaseExample
{
    static void handleCasement()
    {
        Console.WriteLine("Handle Casement");
    }

    static void handleStandard()
    {
        Console.WriteLine("Handle Standard");
    }

    static void handlePatio()
    {
        Console.WriteLine("Handle Patio");
    }

    public static void Main()
    {
        string command = Console.ReadLine();
        
        switch (command.ToLower())
        {
            case "casement":
            case "c":
                handleCasement();
                // Looks like switches in C# falls through by default.
                // Personally I prefer Go approach with explicit
                // fallthrough used when necessary.
                break;
            case "standard":
            case "s":
                // Also, I would expect braces around the code block below.
                // It's not a single line, after all.
                // Is that a special case?
                handleStandard();
                break;
            case "patio":
            case "p":
                handlePatio();
                break;
            default:
                Console.WriteLine("Invalid command");
                break;
        }
    }
}