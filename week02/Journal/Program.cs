using System;

class Program
{
    static void Main(string[] args)
    {
        // Create objects
        Journal theJournal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            // Display menu
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.WriteLine("What would you like to do?");

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                // Write a new entry
                string prompt = generator.GetRandomPrompt();

                Console.WriteLine(prompt);
                string response = Console.ReadLine();

                Entry anEntry = new Entry();
                anEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
                anEntry._promptText = prompt;
                anEntry._entryText = response;

                theJournal.AddEntry(anEntry);

            }
            else if (userChoice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                theJournal.LoadFromFile(filename);
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                theJournal.SaveToFile(filename);
            }
            else if (userChoice == "5")
            {
                break;
            }
        }
    }
}
