// Good example: A simple calculator class

public class Calculator
{
    public int Add(int number1, int number2)
    {
        return number1 + number2;
    }
}

// Bad example: A calculator class with unnecessary functionalities

public class Calculator2
{
    public int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    public int Subtract(int number1, int number2)
    {
        return number1 - number2;
    }

    public int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    public int Divide(int number1, int number2)
    {
        return number1 / number2;
    }

    public int Modulo(int number1, int number2)
    {
        return number1 % number2;
    }
}

// If I only need to perform addition, I don't need the other unnecessary functionalities.
