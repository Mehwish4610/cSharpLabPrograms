using System;

abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Triangle : Shape
{
    private double side1, side2, side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public override double CalculateArea()
    {
        // Using Heron's formula to calculate area
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    public override double CalculatePerimeter()
    {
        return side1 + side2 + side3;
    }
}

class Fp11
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(3);
        Console.WriteLine("Circle - Area: " + circle.CalculateArea() + ", Perimeter: " + circle.CalculatePerimeter());

        Triangle triangle = new Triangle(3, 4, 5);
        Console.WriteLine("Triangle - Area: " + triangle.CalculateArea() + ", Perimeter: " + triangle.CalculatePerimeter());
    }
}
