using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    /*
    The reason we are using a AddEntry method is to
    encapsulate the logic of adding an entry to the journal.
    This allows us to easily add additional functionality
    in the future, such as validation or logging, without having
    to change the code that calls this method. It also makes the
    code more readable and easier to understand, as it clearly
    indicates that we are adding an entry to the journal.
    */
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText} - Entry: {entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        //Add a try-catch block to handle the case where the file does not exist
        try
        {
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split(" - ");

                string date = parts[0].Replace("Date: ", "");
                string prompt = parts[1].Replace("Prompt: ", "");
                string entry = parts[2].Replace("Entry: ", "");

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entryText = entry;

                _entries.Add(newEntry);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file does not exist.");
        }
    }
}