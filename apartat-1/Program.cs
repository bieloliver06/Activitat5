namespace Apartat1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Quina paraula vols que es mostri? : ");
            string? input = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(input);
            }
        }
    }
}