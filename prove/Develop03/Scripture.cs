public class Scripture
{
    private int userChoose;
    private string selectedVerse;
    private Reference referenceHelper = new(); // Instance of Reference

    public Scripture()
    {
        while (true)
        {
            Console.WriteLine("Choose a difficulty: 1 = Easy, 2 = Medium, 3 = Hard");

            if (int.TryParse(Console.ReadLine(), out userChoose) && (userChoose >= 1 && userChoose <= 3))
            {
                break;
            }

            Console.WriteLine("Not a valid difficulty. Please try again.");
        }

        // Get the verse based on difficulty and store it
        selectedVerse = referenceHelper.GetVerse(userChoose);

        Console.WriteLine($"You selected difficulty level {userChoose}. Here is your verse:");
        Console.WriteLine(selectedVerse);
    }

    // Method to return the selected verse so Word can use it
    public string GetSelectedVerse()
    {
        return selectedVerse;
    }
}







