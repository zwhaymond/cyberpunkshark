using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<string> entries;

    public Journal()
    {
        entries = new List<string>();
    }

    // Add a journal entry
    public void AddEntry(string entry)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        entries.Add($"{date}: {entry}");
    }

    // Display the journal
    public void Display()
    {
        Console.WriteLine("Journal Entries:");
        foreach (string entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    // Save the journal to a file
    public void SaveToFile(string filename)
    {
        try
        {
            File.WriteAllLines(filename, entries);
            Console.WriteLine($"Journal saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }

    // Load the journal from a file
    public void LoadFromFile(string filename)
    {
        try
        {
            if (File.Exists(filename))
            {
                entries = new List<string>(File.ReadAllLines(filename));
                Console.WriteLine("Journal loaded successfully.");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }

    // Get all journal entries
    public List<string> GetEntries()
    {
        return entries;
    }

    // Set journal entries
    public void SetEntries(List<string> entries)
    {
        this.entries = entries;
    }
}
