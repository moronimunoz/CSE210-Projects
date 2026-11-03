using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        string question = "yes";
        while (question == "yes")
        {
            Console.WriteLine("---Guess the magic number!---");
            while (true)
            {
                Console.Write("What is your guess?: ");
                string guess = Console.ReadLine();

                if (int.Parse(guess) == number)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
                else if (int.Parse(guess) < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (int.Parse(guess) > number)
                {
                    Console.WriteLine("Lower");
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