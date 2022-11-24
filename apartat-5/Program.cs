namespace Apartat5
{
    class Program
    {
        static void Main()
        {
            string? input;
            double StartingCapital;
            double interest;
            ushort years;
            while (true)
            {
                Console.WriteLine("Introdueix la quantitat a invertit : ");
                input = Console.ReadLine();
                if (input != null)
                {
                    try
                    {
                        StartingCapital = double.Parse(input);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid.");
                    }
                }
            }
            while (true)
            {
                Console.WriteLine("Introdueix l'interes anual (x.xx)% : ");
                input = Console.ReadLine();
                if (input != null)
                {
                    try
                    {
                        interest = (double.Parse(input) / 100) + 1;
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid.");
                    }
                }
            }
            while (true)
            {
                Console.WriteLine("Introdueix el nombre d'anys : ");
                input = Console.ReadLine();
                if (input != null)
                {
                    try
                    {
                        years = ushort.Parse(input);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid.");
                    }
                }
            }
            for (int i = 0; i <= years; i++)
            {
                if (i != 0) StartingCapital = StartingCapital * interest;
                Console.WriteLine($"Any {i} : {Math.Round(StartingCapital, 2)}$");
            }
        }
    }
}