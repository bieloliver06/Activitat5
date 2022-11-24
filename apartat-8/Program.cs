namespace Apartat8
{
    class Program
    {
        static void Main()
        {
            DotNetEnv.Env.Load();
            string? correct_password = Environment.GetEnvironmentVariable("PASSWORD");
            string? input;
            while (true)
            {
                Console.WriteLine("Introdueix la contrasenya : ");
                input = ReadPassword();
                if (input == correct_password) break;
                else Console.WriteLine("Contrasenya incorrecta");
            }
            Console.WriteLine("Contrasenya correcta");
        }
        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        password = password.Substring(0, password.Length - 1);
                        int pos = Console.CursorLeft;
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            Console.WriteLine();
            return password;
        }
    }
}