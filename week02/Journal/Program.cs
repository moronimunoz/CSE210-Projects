using System;

class Program
{
    static void Main(string[] args)
    {
        // Create objects
        Journal journal = new Journal();
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

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString("MM/dd/yyyy");
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);
                
            }
            else if (userChoice == "2")
            {
                journal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }
            else if (userChoice == "5")
            {
                break;
            }
        }
    }
}
