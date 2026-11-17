using System;
using System.Collections.Generic;

// EXTRA: The HideRandomWords method only chooses from words that are still
// visible, so every time the user presses Enter, new words get hidden.
// This avoids wasting turns on words that were already hidden, which makes
// the memorization practice more consistent and predictable.

// EXTRA 2: The program has a library of scriptures and picks one at random each time it runs.

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(new Reference("Isaiah", 58, 5), "Is it such a fast that I have chosen? a day for a man to afflict his soul? is it to bow down his head as a bulrush, and to spread sackcloth and ashes under him? wilt thou call this a fast, and an acceptable day to the Lord?"));
        scriptures.Add(new Scripture(new Reference("Joshua", 1, 9), "Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest."));
        scriptures.Add(new Scripture(new Reference("Hosea", 6, 6), "For I desired mercy, and not sacrifice; and the knowledge of God more than burnt offerings."));

        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            bool isHidden = scripture.IsCompletelyHidden();
            if (isHidden == true)
            {
                break;
            }

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string userChoice = Console.ReadLine();

            if (userChoice == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
        }
    }
}