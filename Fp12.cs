using System;

// Interface for resizable objects
interface Resizable
{
    void resizeWidth(int width);
    void resizeHeight(int height);
}

// Rectangle class implementing Resizable interface
class Rectangle : Resizable
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void resizeWidth(int width)
    {
        if (width <= 0)
        {
            throw new ArgumentException("Width must be greater than 0.");
        }

        this.width = width;
    }

    public void resizeHeight(int height)
    {
        if (height <= 0)
        {
            throw new ArgumentException("Height must be greater than 0.");
        }

        this.height = height;
    }

    public void Display()
    {
        Console.WriteLine("Rectangle Width: " + width);
        Console.WriteLine("Rectangle Height: " + height);
    }
}

class Fp12
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the original width of the rectangle:");
        int originalWidth = GetPositiveIntInput();

        Console.WriteLine("Enter the original height of the rectangle:");
        int originalHeight = GetPositiveIntInput();

        Rectangle rectangle = new Rectangle(originalWidth, originalHeight);
        rectangle.Display();

        Console.WriteLine("Enter the new width of the rectangle:");
        int newWidth = GetPositiveIntInput();

        Console.WriteLine("Enter the new height of the rectangle:");
        int newHeight = GetPositiveIntInput();

        try
        {
            rectangle.resizeWidth(newWidth);
            rectangle.resizeHeight(newHeight);
            Console.WriteLine("Resized successfully!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        rectangle.Display();
    }

    static int GetPositiveIntInput()
    {
        int input;
        while (!int.TryParse(Console.ReadLine(), out input) || input <= 0)
        {
            Console.WriteLine("Please enter a positive integer:");
        }
        return input;
    }
}
