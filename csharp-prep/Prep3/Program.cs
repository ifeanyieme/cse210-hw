using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            PlayGuessMyNumber();
            Console.Write("Do you want to play again? (yes/no): ");
        } while (Console.ReadLine().ToLower() == "yes");
    }

    static void PlayGuessMyNumber()
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guess;
        int numberOfGuesses = 0;

        Console.WriteLine("Welcome to Guess My Number!");

        do
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                continue;
            }

            numberOfGuesses++;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it in {numberOfGuesses} {(numberOfGuesses == 1 ? "guess" : "guesses")}!");
            }
        } while (guess != magicNumber);
    }
}