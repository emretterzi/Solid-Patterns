using System;
using System.IO;

public class Logger
{
    public void Log(string message)
    {
        // Loglama işlemleri
        File.AppendAllText("log.txt", message + "\n");
    }
}

public class Calculator
{
    private Logger _logger;

    public Calculator(Logger logger)
    {
        _logger = logger;
    }

    public int Add(int a, int b)
    {
        int result = a + b;
        _logger.Log($"Addition: {a} + {b} = {result}");
        return result;
    }

    public int Multiply(int a, int b)
    {
        int result = a * b;
        _logger.Log($"Multiplication: {a} * {b} = {result}");
        return result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Logger logger = new Logger();
        Calculator calculator = new Calculator(logger);

        int sum = calculator.Add(3, 4);
        Console.WriteLine("Sum: " + sum);

        int product = calculator.Multiply(3, 4);
        Console.WriteLine("Product: " + product);
    }
}

//Logger sınıfı, loglama işlemlerinden sorumlu bir sınıftır. Sadece loglama işlemlerini gerçekleştiren Log metodunu içermektedir.
//Logları bir dosyaya yazmak için File.AppendAllText metodu kullanılmıştır.


