using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List to store user's numbers.
        List<int> numList = new List<int>();
        int lastNum = -1;

        // A loop to allow the user to add numbers until they add zero.
        while (lastNum != 0)
        {
            Console.Write("Enter number: ");
            lastNum = int.Parse(Console.ReadLine());
            
            numList.Add(lastNum);
        }

        // Remove the last number (zero) as it's not part of the calculations.
        numList.RemoveAt(numList.Count - 1);

        // Find total and average of the list.
        int total = 0;
        foreach (int num in numList)
        {
            total += num;
        }

        double average = (double)total / numList.Count;

        // Display results.
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");

        // Find and display the highest number.
        int maxNum = int.MinValue;
        foreach (int num in numList)
        {
            if (num > maxNum)
            {
                maxNum = num;
            }
        }
        Console.WriteLine($"The biggest number is: {maxNum}");
    }
}
