namespace Apartat2
{
    class Program
    {
        static void Main()
        {
            string? input;
            int age;
            while (true)
            {
                Console.WriteLine("Introdueix la teva edat : ");
                input = Console.ReadLine();
                if (input != null)
                {
                    try
                    {
                        age = int.Parse(input);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid.");
                    }
                }
            }
            for (int i = 1; i <= age; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}