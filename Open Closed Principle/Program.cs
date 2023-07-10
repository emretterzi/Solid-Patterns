using System;

public abstract class Shape
{
    public abstract double Area();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class AreaCalculator  //Alan döndürme fonkiyuonu değişmeden 
//özelleştirebilmek

{
    public double CalculateArea(Shape shape)
    {
        return shape.Area();
    }
}
