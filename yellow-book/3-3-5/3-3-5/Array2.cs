using System;

class Arrays2
{
    static public void Main()
    {
        // The book actually uses string[] months = new string[] {...}
        // I'm so used to Python that I used something that I learned later
        // is called "implicitly typed array".
        string[] months =
        {
            null, // null element for non-existent month 0
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };

        for (int i = 1; i <months.Length; i++)
        {
            Console.WriteLine(months[i]);
        }

        Console.WriteLine();

        // But when you create a new array without initialization, then
        // the 'new' keyword is required.
        string[] week_days = new string[7];
        week_days[0] = "Monday";
        week_days[1] = "Tuesday";
        week_days[2] = "Wednesday";
        week_days[3] = "Thursday";
        week_days[4] = "Friday";
        week_days[5] = "Saturday";
        week_days[6] = "Sunday";

        // While "standard" loops are certainly helpful,
        // the foreach loop are often more intuitive to use for me.
        foreach (string day in week_days)
        {
            Console.WriteLine(day);
        }

        Console.WriteLine();

        // Multidimensional arrays are declared in somewhat different
        // way that I'm used to.
        int[,,] board = new int[3, 3, 3];
        board[1, 1, 1] = 1;
        
        for (int col = 0; col < board.GetLength(0); col++)
        {
            for (int row = 0; row < board.GetLength(1); row++)
            {
                for (int depth = 0; depth < board.GetLength(2); depth++)
                {
                    Console.WriteLine((int)board[col, row, depth]);
                }
            }
        }
    }
}
