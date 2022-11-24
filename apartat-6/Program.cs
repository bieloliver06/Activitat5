namespace Apartat6
{
    class Program
    {
        static void Main()
        {
            string? input;
            string things;
            uint height;
            while (true)
            {
                Console.WriteLine("Introdueix l'altura del triangle : ");
                input = Console.ReadLine();
                if (input != null)
                {
                    try
                    {
                        height = uint.Parse(input);
                        Console.WriteLine();
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid.");
                    }
                }
            }
            for (int i = 1; i <= height; i++)
            {
                things = new String('*', i);
                Console.WriteLine(things);
            }
        }
    }
}