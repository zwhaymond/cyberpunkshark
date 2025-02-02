using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        List<string> savedEntries = new List<string>();
        Journal journal = new Journal();

        do
        {
            Console.WriteLine("Welcome to your personal electronic journal!");
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do?" );
            userInput = int.Parse(Console.ReadLine());
           
            if (userInput == 1)
            {
                Prompt prompt1 = new Prompt();
                Console.WriteLine($"Your prompt is: {prompt1.Display()}");
                string promptForEntry = prompt1.Display();
                string _userEntry = Console.ReadLine();
                journal.AddEntry(promptForEntry);
                journal.AddEntry(_userEntry);
            }
 
            else if (userInput == 2)
            {
                Console.WriteLine("Answers entered:");
                journal.Display();
            }
 
            else if (userInput == 3)
            {
                Console.Write("What is the filename to load? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
 
            else if (userInput == 4)
            {
                Console.Write("What is the filename to save? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
 
            else
            {
                Console.WriteLine("Please enter a number between 1 and 5.");
            }
       
        } while (userInput != 5);
    }
}
