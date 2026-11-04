using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        string question = "yes";
        while (question == "yes")
        {
            Console.WriteLine("\n---Guess the magic number!---");
            int counter = 0;
            while (true)
            {
                Console.Write("What is your guess?: ");
                string guess = Console.ReadLine();

                if (int.Parse(guess) == number)
                {
                    Console.WriteLine("You guessed it!");
                    counter++;
                    Console.WriteLine($"It took you {counter} guesses.");
                    break;
                }
                else if (int.Parse(guess) < number)
                {
                    Console.WriteLine("Higher");
                    counter++;
                }
                else if (int.Parse(guess) > number)
                {
                    Console.WriteLine("Lower");
                    counter++;
                }
            }
            Console.Write("Do you want to play again? (yes/no): ");
            question = Console.ReadLine().ToLower();
            if (question != "yes")
            {
                break;
            }
        }
    }
}