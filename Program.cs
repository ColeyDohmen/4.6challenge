using System;

namespace _4._6challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                // Console.WriteLine("Hello World!");
                Console.WriteLine(@"Would you like to login?
            Y / N");
                ConsoleKeyInfo userInput = System.Console.ReadKey();
                Console.Clear();
                if (userInput.Key == ConsoleKey.Y)
                {
                    System.Console.WriteLine("What is your log in?");
                    string loginInfo = Console.ReadLine();
                    System.Console.WriteLine("What is your password?");
                    string password = Console.ReadLine();

                }
                else if (userInput.Key == ConsoleKey.N)
                {
                    System.Console.WriteLine("Sad days, maybe next time");
                    running = false;
                }
            }
        }
    }
}
