using System;


class Program
{
    public static void Main(string[] args)
    {
    Reference reference = new();
    Console.WriteLine("Choose a difficulty: 1 = Easy, 2 = Medium, 3 = Hard");

    int difficulty;
    while (!int.TryParse(Console.ReadLine(), out difficulty) || difficulty < 1 || difficulty > 3)
    {
        Console.WriteLine("Invalid selection. Please enter 1, 2, or 3.");
    }

    // Pass difficulty to Scripture constructor
    Scripture scripture = new(difficulty); 

    Word word = new(reference.GetVerse(difficulty, out string location), location);

    // Removed the duplicate print statement here
    while (true)
    {
        Console.WriteLine("\nPress \"Enter\" to remove a word or type \"No\" to quit.");
        string userInput = Console.ReadLine()?.ToUpper();

        if (userInput == "NO") break;

        word.RemoveWord(); // The first removal will print the verse
    }
    }


}
