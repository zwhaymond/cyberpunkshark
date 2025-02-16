public class Scripture
{
    private int userChoose;
    private Reference reference = new Reference();

    // Constructor for Scripture class with difficulty as parameter
    public Scripture(int difficulty)
    {
        userChoose = difficulty;

        // Get verse and location from the Reference class
        string location;
        string verse = reference.GetVerse(userChoose, out location); // Correctly call GetVerse with out parameter

        Console.WriteLine($"\n{location} {verse}"); // Display verse with location
    }
}



