﻿namespace Apartat7
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Taula del {i} : ");
                for (int j = 1; j <= 10; j++) Console.WriteLine($"{i} * {j} = {i * j}");
                Console.WriteLine();
            }
        }
    }
}