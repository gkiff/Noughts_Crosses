// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, Noughts & Crosses!");
TicTacToe.DisplayGrid();
TicTacToe.GetUserChoice();

public static class TicTacToe
{
    public static char[,] Grid =
    {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };

    public static void DisplayGrid()
    {
        Console.Clear();
        Console.WriteLine("-------------");
        for (int i = 0; i < Grid.GetLength((0)); i++)
        {
            for (int j = 0; j < Grid.GetLength((1)); j++)
            {
                if (j != 1)
                {
                    Console.Write("| " + Grid[i, j] + " |");
                }
                else
                {
                    Console.Write(" " + Grid[i, j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("-------------");
        }
    }

    public static int GetUserChoice()
    {
        bool response = false;
        int choice = -1;
        while (!response)
        {
            Console.WriteLine("Enter a choice (1-9) : ");
            response = int.TryParse(Console.ReadLine(), out choice);
            if ((choice < 1) || (choice > 9) || (CheckUsed() == false))
            {
                response = false;
            }
        }

        return choice;
    }

    public static bool CheckUsed()
    {
        int currRow
        
        return false;
    }
}