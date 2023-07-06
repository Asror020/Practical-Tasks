using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the string: ");
        string str = Console.ReadLine();

        int maxCount = 1;
        int currentCount = 1;
        char previousChar = str[0];

        for (int i = 1; i < str.Length; i++)
        {
            char currentChar = str[i];

            if (currentChar != previousChar)
            {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            }
            else
            {
                currentCount = 1;
            }

            previousChar = currentChar;
        }

        Console.WriteLine($"The maximum number of unequal consecutive characters is {maxCount}.");
    }
}