using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        int PromptUserNumber = int.Parse(Console.ReadLine());

        int squaredNumber = PromptUserNumber * PromptUserNumber;

        Console.WriteLine(name + " ,the square of your number is " + squaredNumber + ".");

    }
}