//TODO: Prompt the user to enter a numeric grade (0-100)
//TODO: Validate the input to ensure it is a number within the valid range
//DONE: Create a method 'GetLetterGrade' to return letter grade
//DONE: Display the letter grade
//TODO: Aske the user if the want to evaluate another grade
//TODO: Repeats until the user exists

using System;
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
                return "A";
            case >= 80 and < 90:
                return "B";
            case >= 70 and < 80:
                return "C";
            case >= 60 and < 70:
                return "D";
            default:
                return "F";
        }
    }

}