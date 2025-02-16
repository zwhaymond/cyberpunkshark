public class Word
{
    private List<string> wordList = new();
    private string originalVerse; 

    public Word(string verse)  // Accept verse as parameter
    {
        originalVerse = verse;
        SplitVerse();
    }

    public void SplitVerse()
    {
        wordList = new List<string>(originalVerse.Split(" ")); // Split the verse into words
    }

    public void RemoveWord()
    {
    // Check if all words are already hidden
    if (wordList.All(word => word == "____"))
    {
        Console.WriteLine("All the words are hidden.");
        return;
    }

    Random random = new();
    int index;

    do
    {
        index = random.Next(wordList.Count);
    } 
    while (wordList[index] == "____"); // Ensure we pick an unhidden word

    wordList[index] = "____"; // Hide the selected word

    Console.WriteLine(string.Join(" ", wordList));  // Print updated verse
    }

}


