using System;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Dictionary<SubjectName, Grade> Grades = new Dictionary<SubjectName, Grade>();



    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public void GetStudentName()
    {
        Console.Write("Enter the student's first name: ");
        FirstName = Console.ReadLine() ?? string.Empty;
        while (string.IsNullOrWhiteSpace(FirstName))
        {
            Console.Write("Name cannot be empty. Please enter a first name: ");
            FirstName = Console.ReadLine() ?? string.Empty;
        }

        Console.Write("Enter the student's last name: ");
        LastName = Console.ReadLine() ?? string.Empty;
        while (string.IsNullOrWhiteSpace(LastName))
        {
            Console.Write("Name cannot be empty. Please enter a last name: ");
            LastName = Console.ReadLine() ?? string.Empty;
        }
    }

    // Returns the full name of the student
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}