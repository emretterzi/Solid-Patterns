using System;

// Bad example (repetitive code):
public class Calculation
{
    public void Addition(int a, int b)
    {
        int result = a + b;
        Console.WriteLine("Result of addition: " + result);
    }

    public void Subtraction(int a, int b)
    {
        int result = a - b;
        Console.WriteLine("Result of subtraction: " + result);
    }

    public void Multiplication(int a, int b)
    {
        int result = a * b;
        Console.WriteLine("Result of multiplication: " + result);
    }

    public void Division(int a, int b)
    {
        int result = a / b;
        Console.WriteLine("Result of division: " + result);
    }
}

// Good example (reusability):
public class Calculations
{
    public void PerformOperation(string operation, int a, int b)
    {
        int result = 0;

        switch (operation)
        {
            case "addition":
                result = a + b;
                break;
            case "subtraction":
                result = a - b;
                break;
            case "multiplication":
                result = a * b;
                break;
            case "division":
                result = a / b;
                break;
            default:
                Console.WriteLine("Invalid operation!");
                return;
        }

        Console.WriteLine("Result of " + operation + ": " + result);
    }
}
