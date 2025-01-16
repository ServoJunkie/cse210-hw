using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        //First, we define a list to fill with numbers and a boolean variable to break a loop when the user is done entering numbers.
        List<float> numbers = new List<float>();
        bool finished = false;
        
        //This code prompts the user to enter several numbers. Then, it converts their entry into a float. If it is 0, it sets the
        //boolean variable 'finished' to true and ends the loop. Otherwise, it adds the entry to the list and repeats.
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        do
        {
            Console.Write("Enter number: ");
            string newNumberEntry = Console.ReadLine();
            float newNumber = float.Parse(newNumberEntry);

            if (newNumber == 0)
            {
                finished = true;
            }
            else
            {
                numbers.Add(newNumber);
            }
        } while (finished == false);

        //Defining necessary varibles to calculate the sum, average, and maximum. The maximum is set to a starting value of the first
        //value in the list.
        float sum = 0;
        int quantity = 0;
        float maximum = numbers[0];

        //This code goes through the list. For each value, we add it to the sum, increase the quantity value by one, and redefine the
        //maximum as the new value if it is larger than the current value.
        foreach (float number in numbers)
        {
            sum = sum + number;
            quantity++;

            if (number > maximum)
            {
                maximum = number;
            }
        }

        //The average is calculated.
        double average = ((float)sum) / quantity;

        //This code writes the results to the terminal for the user to see.
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maximum}");
    }
}