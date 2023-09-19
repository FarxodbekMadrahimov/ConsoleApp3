using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter the number of rows for the diamond: ");
        if (int.TryParse(Console.ReadLine(), out int numRows))
        {
            PrintDiamond(numRows);
        }



    }

    static void PrintDiamond(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (int i = n - 2; i >= 0; i--)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}