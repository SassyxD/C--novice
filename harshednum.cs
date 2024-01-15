//harshedNum

using System;

class Program
{
    static void Main()
    {
        int[] yeet = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            yeet[i] = num;
        }

    }
}