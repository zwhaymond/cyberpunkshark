using System;

class Program
{
    static void Main()
    {
        // Generate a magic number.
        Random random = new Random();
        // Generates a random number between 1 and 10
        int magicNum = random.Next(1, 11); 
        int guess = 0;

        while (magicNum != guess)
        {
            // Ask user for a guess.
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            // If statement determining if it's too high, low, or is the correct guess.
            if (magicNum == guess)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (magicNum > guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }
    }
}
