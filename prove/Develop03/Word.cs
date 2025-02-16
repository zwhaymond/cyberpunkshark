public class Word
{
    private List<string> wordList;
    private string location; // Stores scripture reference

    public Word(string verse, string reference)
    {
        wordList = new List<string>(verse.Split(" ")); // Convert verse into list
        location = reference; // Store scripture location
    }

    public void RemoveWord()
    {
        // Check if all words are already hidden
        if (wordList.All(word => word == "____"))
        {
            Console.WriteLine($"{location} {string.Join(" ", wordList)}"); // Show full hidden verse
            Console.WriteLine("\nAll the words are hidden.");
            Environment.Exit(0);  // Exit the program
        }

        Random random = new();
        int index;

        do
        {
            index = random.Next(wordList.Count);
        } 
        while (wordList[index] == "____"); // Ensure we pick an unhidden word

        wordList[index] = "____"; // Hide the selected word

        Console.WriteLine($"{location} {string.Join(" ", wordList)}");  // Print updated verse with location
    }

    // Override ToString to show only the location and current verse with hidden words
    public override string ToString()
    {
        return $"{location} {string.Join(" ", wordList)}";
    }
}

