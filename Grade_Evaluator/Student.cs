using System;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Dictionary<SubjectEnum, Grade> Grades = new Dictionary<SubjecEnum, Grade>();


    public Student (string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string GetStudentName()
    {
        //Get name of student so it can be stored in a list of students/subject grades
        Console.WriteLine("Enter the student's First name: ");
        string studentFirstName = Console.ReadLine();

        //Checks if First Name is empty or a space and prompts user to enter a valid name
        while (string.IsNullOrWhiteSpace(studentFirstName))
        {
            Console.Write("Name cannont be empty. Please enter a name.");
            studentFirstName = Console.ReadLine();
        }
        return studentFirstName;

        Console.WriteLine("Enter the student's last name: ");
        string studentLastName = Console.ReadLine();

        //Checks if Last Name is empty or a space and prompts user to enter a valid name
        while (string.IsNullOrWhiteSpace(studentLastName))
        {
            Console.Write("Name cannont be empty. Please enter a name.");
            studentLastName = Console.ReadLine();
        }
        return studentLastName;

        string name = studentFirstName + studentLastName;
    }
    
    // Returns the full name of the student
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}