class Program
{
    public static void Main(string[] args)
    {
        Scripture scripture = new();
        string verse = scripture.GetSelectedVerse(); // Retrieve the verse
        Word word = new(verse); // Pass the verse to Word

        while (true)
        {
            Console.WriteLine("\nPress \"Enter\" to remove a word or type \"No\" to quit.");
            string userInput = Console.ReadLine()?.ToUpper();

            if (userInput == "NO") break;

            word.RemoveWord();
        }
    }
}

