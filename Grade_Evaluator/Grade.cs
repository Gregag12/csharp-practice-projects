//TODO: Prompt the user to enter a numeric grade (0-100)
//TODO: Validate the input to ensure it is a number within the valid range
//DONE: Create a method 'GetLetterGrade' to return letter grade
//DONE: Display the letter grade
//TODO: Aske the user if the want to evaluate another grade
//TODO: Repeats until the user exists

using System;
using System.Security.Cryptography.X509Certificates;

public class Grade
{
    public int Score { get; set; }


    public Grade(int score)
    {
        Score = score;
    }

    // Returns the letter grade based on the numeric score
    public string GetLetterGrade(int a)
    {
        switch (a) //Checks if the integer is between 0-100
        {
            case >= 90:
                Console.WriteLine("A");
                break;
            case >= 80 and < 90:
                Console.WriteLine("B");
                break;
            case >= 70 and < 80:
                Console.WriteLine("C");
                break;
            case >= 60 and < 70:
                Console.WriteLine("D");
                break;
            case < 60:
                Console.WriteLine("F");
            default:
                Console.WriteLine("Please enter a valid number grade");
                break;
        }
    }

}