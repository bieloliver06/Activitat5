﻿namespace Apartat3
{
    class Program
    {
        static void Main()
        {
            string? input;
            uint number;
            string output = "";
            while (true)
            {
                Console.WriteLine("Introdueix fins a quin nombre vols saber els nombres imparells : ");
                input = Console.ReadLine();
                if (input != null)
                {
                    try
                    {
                        number = uint.Parse(input);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El nombre introduit no és valid.");
                    }
                }
            }
            for (uint i = 0; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i}, ");
                    output += $"{i}, ";
                }
            }
            if (output[output.Length - 2] == ',') Console.Write("\b \b\b \b");
        }
    }
}
