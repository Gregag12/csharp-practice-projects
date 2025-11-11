using System;

public class Subject
{
    public SubjectName ClassName { get; set; }

    public Subject(SubjectName className)
    {
        ClassName = className;
    }

    // Prints a list of possible subjects
    public void SelectSubjectFromList()
    {
        Console.WriteLine("Here is the list of possible subjects: ");

        foreach (var name in Enum.GetValues(typeof(SubjectName)))
        {
            Console.WriteLine($"- {name}");
        }
    }

    public string GetSubjectName()
    {
        // Prompt user
        Console.Write("Enter the subject: ");
        string? subject = Console.ReadLine() ?? string.Empty; // Ensure non-null

        // Validate input
        while (string.IsNullOrWhiteSpace(subject))
        {
            Console.Write("Subject cannot be empty. Please enter a valid subject: ");
            subject = Console.ReadLine() ?? string.Empty; // Ensure non-null
        }

        return subject;
    }
}
