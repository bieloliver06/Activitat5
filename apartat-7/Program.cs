namespace Apartat7
{
    class Program
    {
        static void Main()
        {
            string? input;
            int number;
            while (true)
            {
                Console.WriteLine("Introdueix de quin nonmbre vols la taula de multiplicar : ");
                input = Console.ReadLine();
                if (input != null)
                {
                    try
                    {
                        number = int.Parse(input);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid.");
                    }
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}