﻿using System;
class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        Random random = new Random();
        int evenCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000);
            Console.Write(numbers[i] + " ");
            if (numbers[i] % 2 == 0)
            {
                evenCount++;
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine($"четных чисел: {evenCount}");
    }
}
