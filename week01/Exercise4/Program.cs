using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        System.Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            System.Console.Write("Enter a number: ");
            string text = System.Console.ReadLine();
            int input;
            bool esNumeroValido = int.TryParse(text, out input);

            if (esNumeroValido == false)
            {
                System.Console.WriteLine("Please enter a valid number.");
                continue;
            }
            if (input == 0)
                break;

            numbers.Add(input);
        }

        if (numbers.Count == 0)
        {
            System.Console.WriteLine("No numbers were entered.");
            return;
        }

        int sum = 0;
        int smallestPositive = 0;
        bool foundPositive = false;

        foreach (int n in numbers)
        {
            sum += n;

            if (n > 0 && (!foundPositive || n < smallestPositive))
            {
                smallestPositive = n;
                foundPositive = true;
            }
        }

        numbers.Sort();
        System.Console.WriteLine("The sum is: " + sum);
        System.Console.WriteLine("The average is: " + (double)sum / numbers.Count);

        if (foundPositive)
        {
            System.Console.WriteLine("The smallest positive number is: " + smallestPositive);
        }
        else
        {
            System.Console.WriteLine("There are no positive numbers.");
        }
        System.Console.WriteLine("The sorted list is:\n" + string.Join("\n", numbers));
    }
}