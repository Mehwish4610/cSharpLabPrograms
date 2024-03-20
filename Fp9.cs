using System;

class Complex
{
    private double real;
    private double imaginary;

    // Constructor
    public Complex(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    // Method to overload the binary operator '+'
    public static Complex operator +(Complex c1, Complex c2)
    {
        double realSum = c1.real + c2.real;
        double imaginarySum = c1.imaginary + c2.imaginary;
        return new Complex(realSum, imaginarySum);
    }

    // Method to display complex number
    public override string ToString()
    {
        return real + " + " + imaginary + "i";
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the real part of the first complex number:");
            double real1;
            if (!double.TryParse(Console.ReadLine(), out real1))
            {
                throw new FormatException("Invalid input for real part. Please enter a valid number.");
            }

            Console.WriteLine("Enter the imaginary part of the first complex number:");
            double imaginary1;
            if (!double.TryParse(Console.ReadLine(), out imaginary1))
            {
                throw new FormatException("Invalid input for imaginary part. Please enter a valid number.");
            }

            Console.WriteLine("Enter the real part of the second complex number:");
            double real2;
            if (!double.TryParse(Console.ReadLine(), out real2))
            {
                throw new FormatException("Invalid input for real part. Please enter a valid number.");
            }

            Console.WriteLine("Enter the imaginary part of the second complex number:");
            double imaginary2;
            if (!double.TryParse(Console.ReadLine(), out imaginary2))
            {
                throw new FormatException("Invalid input for imaginary part. Please enter a valid number.");
            }

            Complex c1 = new Complex(real1, imaginary1);
            Complex c2 = new Complex(real2, imaginary2);

            Complex sum = c1 + c2;
            Console.WriteLine("Sum of the complex numbers: " + sum);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
