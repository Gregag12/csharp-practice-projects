# BankAccount

A simple console application to simulate a basic bank account. This project is designed to practice C# object-oriented programming concepts, including classes, scope, and access modifiers.

## 🎯 Features

  - Create a bank account with an initial balance.

  - Deposit money into the account.

  - Withdraw money from the account (with simple balance validation).

  - Display the current account balance.

  - Demonstrates proper use of classes, private/public members, and method scope.

## 🧠 Concepts Practiced

  - Classes
    - The BankAccount class encapsulates all properties and behaviors of a bank account.
  - Scope
  - Local variables, method parameters, and class-level variables demonstrate variable scope.
  - Access Modifiers
    - private fields ensure internal data cannot be modified directly.
    - public methods provide controlled access to account operations.

## Example Usage
BankAccount account = new BankAccount("John Doe", 500);

// Deposit money
account.Deposit(200);

// Withdraw money
account.Withdraw(100);

// Display balance
Console.WriteLine(account.GetBalance()); // Output: 600

## Getting Started

### Clone the repository:

git clone <repository_url>


### Navigate to the project folder:

cd BankAccount

Build and run:

dotnet run

## Class Overview
public class BankAccount
{
    private string accountHolder;
    private decimal balance;
    public Datetime AccountStarted;

    public BankAccount(string name, decimal initialBalance) { ... }
    public void Deposit(decimal amount) { ... }
    public void Withdraw(decimal amount) { ... }
    public decimal GetBalance() { ... }
    public string GetAccountInfo() { ... }
}


private fields: accountHolder, balance

public methods: Deposit, Withdraw, GetBalance, GetAccountInfo

## 🪪 License

This project is licensed under the [MIT License](LICENSE).

© 2025 Greg Garrett