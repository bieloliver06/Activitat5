namespace Apartat4
{
    class Program
    {
        static void Main()
        {
            string? input;
            int number;
            while (true)
            {
                Console.WriteLine("Introduix el nombre per començar la compta enrere : ");
                input = Console.ReadLine();
                if (input != null)
                {
                    try
                    {
                        number = int.Parse(input);
                        Console.WriteLine();
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid.");
                    }
                }
            }
            for (int i = number; i >= 0; --i)
            {
                Console.WriteLine(i);
            }
        }
    }
}