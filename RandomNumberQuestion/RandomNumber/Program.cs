using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = GetUserInput();
            var randomNumberGernerator = new RandomNumberGenerator();
            var result = randomNumberGernerator.Generate(userInput);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int GetUserInput()
        {
            Console.Write("Please enter a number: ");
            var userInput = Console.ReadLine();
            int.TryParse(userInput, out var result);
            return result;
        }
    }
}
