using System;

public class Number
{
    public int UserNumber { get; set; }

    public Number(int number)
    {
        UserNumber = number;    
    }

    //DONE: Create a method `FindLargest(int a, int b, int c)` that returns the largest number.  
    public int FindLargestNumber(int a, int b, int c)
    {
        // Compare number 1 and number 2 -- keep largest number
        int[] numbers = { a, b, c };

        // Compare known largest number with last number
        int largestNumebr = numbers.Max();

        // Return laragest number
        return largestNumebr;
    }
    
    //DONE: Create a method `IsEven(int number)` that returns `true` if the number is even.  
    public string IsEven(int number)
    {
        if (number % 2 = 0)
        {
            return $"{number} is even"; // returns even number
        }
        else
        {
            return $"{number} is odd"; // returns odd number
        }
    }
}