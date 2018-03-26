using System;
using m0201.Exceptions;

namespace m0201
{
    internal class Program
    {
        private static void Main()
        {
            ConsoleKeyInfo answer;

            do
            {
                Console.WriteLine("Type some lines of text.\n\n" +
                                  "Type \"result\" to see the result.\n");

                var trimmer = new InputTrimmer();

                var currLine = Console.ReadLine();

                while (currLine?.Trim().ToLower() != "result")
                {
                    if (currLine?.Length == 0)
                    {
                        throw new UserInputException("Line cannot be empty.");
                    }

                    trimmer.Add(currLine);

                    currLine = Console.ReadLine();
                }

                Console.WriteLine();

                trimmer.Print();

                do
                {
                    Console.Write("\nContinue? [y/n]: ");

                    answer = Console.ReadKey();

                    Console.WriteLine("\n");
                }
                while (answer.Key != ConsoleKey.Y
                       && answer.Key != ConsoleKey.N);
            }
            while (answer.Key == ConsoleKey.Y);
        }
    }
}
