//DONE: Ask the user to input three integers.  
//DONE: Create a method `FindLargest(int a, int b, int c)` that returns the largest number.  
//DONE: Create a method `IsEven(int number)` that returns `true` if the number is even.  
//DONE: Display the largest number and whether it’s even or odd.  
//FIXME:error CS0131: The left-hand side of an assignment must be a variable, property or indexer
//FIXME: warning CS8600: Converting null literal or possible null value to non-nullable type.
using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the newly created Number Analyzer!");
        Console.WriteLine("We'll start by choosing 3 whole numbers.");

        List<int> numbers = new List<int>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter number #{i + 1}: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                i--; // Decrement i to repeat this iteration
            }
        }

        Console.WriteLine("\nYou've entered the numbers: " + string.Join(", ", numbers));
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    
    }
}