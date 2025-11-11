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
        //Get name of subject so it can be stored in a list of students/subject grades
        Console.WriteLine("Enter the subject: ");
        string subject = Console.ReadLine();

        //Checks if name is empty or a space and prompts user to enter a valid name
        while (string.IsNullOrWhiteSpace(subject))
        {
            Console.Write("Subject cannont be empty. Please enter a valid subject.");
            subject = Console.ReadLine();
        }
        return subject;
    }
}