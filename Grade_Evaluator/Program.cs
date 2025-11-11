//DONE: Prompt the user to enter a numeric grade (0-100)
//Done: Validate the input to ensure it is a number within the valid range
//DONE: Create a method 'GetLetterGrade' to return letter grade
//DONE: Create classes: Student, Subject, Grade
//DONE: Create methods for GetStudentName, GetSubjectName, SelectSubjectFromList, GetFullName
//DONE: Create subject enum
//DONE: Display the letter grade
//DONE: Aske the user if the want to evaluate another grade
//DONE: Repeats until the user exists

using System;
using System.Collections.Generic;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        do
        {
            // --- 1. Create or select student ---
            Student student = new Student("", "");
            student.GetStudentName(); // populates FirstName/LastName
            students.Add(student);

            // --- 2. Inner loop: Add grades for this student ---
            do
            {
                // --- Prompt for subject ---
                Subject subjectHelper = new Subject(SubjectName.Math);
                subjectHelper.SelectSubjectFromList();

                SubjectName selectedSubject;
                while (true)
                {
                    string subjectInput = subjectHelper.GetSubjectName();
                    if (Enum.TryParse(subjectInput, true, out selectedSubject) &&
                        Enum.IsDefined(typeof(SubjectName), selectedSubject))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid subject. Please enter a valid subject from the list.");
                }

                // --- Prompt for grade ---
                Console.Write($"Enter numeric grade for {selectedSubject}: ");
                string input = Console.ReadLine() ?? string.Empty;
                int numericGrade;
                while (!int.TryParse(input, out numericGrade) || numericGrade < 0 || numericGrade > 100)
                {
                    Console.Write("Invalid input. Enter number 0-100: ");
                    input = Console.ReadLine() ?? string.Empty;
                }

                Grade grade = new Grade(numericGrade);
                student.Grades[selectedSubject] = grade; // add or overwrite

                Console.WriteLine($"{student.GetFullName()} - {selectedSubject}: {grade.GetLetterGrade(numericGrade)}");

                // --- Ask to add another grade for the same student ---
                Console.Write("Would you like to enter another grade for the same student? (y/n): ");
                string? anotherGrade = Console.ReadLine();
                if ((anotherGrade ?? string.Empty).ToLower() != "y")
                {
                    break; // exit inner loop to go to next student
                }

            } while (true);

            // --- Ask to add another student ---
            Console.Write("Would you like to enter a grade for another student? (y/n): ");
            string? anotherStudent = Console.ReadLine();
            if ((anotherStudent ?? string.Empty).ToLower() != "y")
            {
                Console.WriteLine("Goodbye!");
                break; // exit outer loop
            }

        } while (true);
    }
}
