using System;
using System.ComponentModel.Design;

public class Program
{
    void Main(string[] args)
    {
        
        string choice;
        Console.WriteLine("Choose a option: \n1-Breathing Activity\n 2- Reflection Activity\n 3- Listening Activity");
        choice = Console.ReadLine();
        BreathingActivity breathing = new();
        ReflectionActivity reflection = new();
        ListeningActivity listening = new();
        

        if (choice == "1")
        {
            breathing.Breathing(string activityType, string desctiptionType);
        }

        else if (choice == "2")
        {
            reflection.Reflection(string activityType, string desctiptionType);
        }

        else if (choice == "3")
        {
            listening.Listening(string activityType, string desctiptionType);
        }

        else if (choice == "4")
        {
            Console.WriteLine("Thanks for participating!");
        }

        else 
        {
            Console.WriteLine("You did not choose a vaild option.");
        }
    }   
}