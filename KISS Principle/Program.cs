using System;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        int sum = calculator.Add(3, 4);
        Console.WriteLine("Sum: " + sum);

        int product = calculator.Multiply(3, 4);
        Console.WriteLine("Product: " + product);
    }
}

//Calculator sınıfı basit bir hesap makinesini temsil ediyor.
//Sınıf içerisinde yalnızca iki temel işlem, yani toplama ve çarpma, bulunmaktadır.
