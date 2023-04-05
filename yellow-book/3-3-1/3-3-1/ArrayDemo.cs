using System;

class ArrayDemo
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

    public static void Main()
    {
        const int SCORE_SIZE = 11;
        int[] scores = new int[SCORE_SIZE];
        for (int i=0; i<SCORE_SIZE; i=i+1)
        {
            scores[i] = readInt("Score: ", 0, 1000);
        }
    }
}
