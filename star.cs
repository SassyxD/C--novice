//star

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        DrawPattern(num);
    }

    static void DrawPattern(int num)
    {
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(". ");
            }
            Console.WriteLine();
        }

        for (int i = num - 1; i >= 1; i--)
        {
            for (int j = 1; j < i; j++)
            {
                Console.Write(". ");
            }
            Console.WriteLine();
        }
    }
}