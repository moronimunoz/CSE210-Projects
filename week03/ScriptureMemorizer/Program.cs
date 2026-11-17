using System;
using System.Collections.Generic;

// EXTRA: The HideRandomWords method only chooses from words that are still
// visible, so every time the user presses Enter, new words get hidden.
// This avoids wasting turns on words that were already hidden, which makes
// the memorization practice more consistent and predictable.

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Hosea", 6, 6);
        Scripture scripture = new Scripture(reference, "For I desired mercy, and not sacrifice; and the knowledge of God more than burnt offerings.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            bool isHidden = scripture.IsCompletelyHidden();
            if (isHidden == true)
            {
                break;
            }

            Console.WriteLine($"\nPress enter to continue or type 'quit' to finish:");
            string userChoice = Console.ReadLine();

            if (userChoice == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
        }
    }
}