using System;

// Base class Shape
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape...");
    }

    public virtual void Erase()
    {
        Console.WriteLine("Erasing a shape...");
    }
}

// Circle subclass
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle...");
    }

    public override void Erase()
    {
        Console.WriteLine("Erasing a circle...");
    }
}

// Triangle subclass
class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a triangle...");
    }

    public override void Erase()
    {
        Console.WriteLine("Erasing a triangle...");
    }
}

// Square subclass
class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square...");
    }

    public override void Erase()
    {
        Console.WriteLine("Erasing a square...");
    }
}

class Fp10
{
    static void Main(string[] args)
    {
        try
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle();
            shapes[1] = new Triangle();
            shapes[2] = new Square();

            Console.WriteLine("Drawing and erasing shapes:");
            foreach (var shape in shapes)
            {
                DrawAndErase(shape);
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static void DrawAndErase(Shape shape)
    {
        try
        {
            shape.Draw();
            shape.Erase();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error handling shape: " + ex.Message);
        }
    }
}
