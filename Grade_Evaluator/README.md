# 🧮 Grade Evaluator

A small C# console application that evaluates a student’s grade based on numeric input and returns the corresponding letter grade.

This project is part of my **C# Practice Projects** collection to practice aspects such as variables, types, conditional statements, methods, and loops.

---

## 🎯 Features

 - Accepts numeric grades (0–100) from user input
 - Validates that the input is a number within range
 - Converts numeric grades to letter grades (A–F)
 - Demonstrates:
    - Variables and data types
    - Conditional statements (if, else if, else)
    - Loops (while or do while)
    - Methods and scope
    - Boolean operators

## 🧠 Concepts Practiced

- Variables & Types
- Conditional Statements
- Methods & Scope
- Boolean Logic
- Loops
- Access Modifiers (e.g. private, public)
- Static Methods 

---

## 📋 Requirements

1. Prompt the user to enter a numeric grade (0–100).
2. Validate the input to ensure it is a number within the valid range.
3. Create a method GetLetterGrade(int score) that:
  - Returns "A" for scores 90–100
  - Returns "B" for scores 80–89
  - Returns "C" for scores 70–79
  - Returns "D" for scores 60–69
  - Returns "F" for scores below 60
4. Display the corresponding letter grade to the user.
5. Ask the user if they want to evaluate another grade.
6. Repeat until the user chooses to exit.
7. Use proper data types, scope, and access modifiers.
8. Include comments explaining your logic and method purpose.
---

## 🧩 Example Output

Enter your grade (0-100): 88
Your letter grade is: B
Would you like to enter another grade? (y/n): y
Enter your grade (0-100): 102
Invalid input. Please enter a number between 0 and 100.
Enter your grade (0-100): 95
Your letter grade is: A
Would you like to enter another grade? (y/n): n
Goodbye!

## 🪪 License

This project is licensed under the [MIT License](LICENSE).

© 2025 Greg Garrett