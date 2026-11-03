using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            if (input == 0)
            {
                break;
            }
            numberList.Add(input);
        }

        int sum = 0;
        foreach (int number in numberList)
        {
            sum += number;
        }

        int positiveNumber = numberList.Where(n => n > 0).DefaultIfEmpty(int.MaxValue).Min();

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + (double)sum / numberList.Count);
        Console.WriteLine("The smaller positive number is: " + positiveNumber);
        Console.WriteLine("The sorted list is: " + string.Join(", ", numberList.OrderBy(n => n)));
    }
}