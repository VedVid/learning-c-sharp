using System;

class OutReferences
{
    static string readString(string prompt)
    {
        string result;
        do
        {
            Console.Write(prompt);
            result = Console.ReadLine();
        } while (result == "");
        return result;
    }

    static int readInt(string prompt, int low, int high)
    {
        int result;
        do
        {
            string intString = readString(prompt);
            result = int.Parse(intString);
        } while ((result < low) || (result > high));
        return result;
    }

    static void readPerson(out string name, out int age)
    {
        name = readString("Enter your name: ");
        age = readInt("Enter your age: ", 0, 100);
    }

    public static void Main()
    {
        string name;
        int age;
        readPerson(out name, out age);
    }
}
