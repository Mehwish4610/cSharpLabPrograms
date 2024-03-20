using System;

class Fp4
{
    static void Main(string[] args)
    {
        try
        {
            // Division by Zero Exception
            Console.WriteLine("Demonstrating Division by Zero Exception:");
            Console.WriteLine("Enter the dividend:");
            int dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the divisor:");
            int divisor = int.Parse(Console.ReadLine());

            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            int result = dividend / divisor;
            Console.WriteLine("Result of division: " + result);

            // Index Out of Range Exception
            Console.WriteLine("\nDemonstrating Index Out of Range Exception:");
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException("Size must be greater than 0.");
            }

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }

            Console.WriteLine("Enter the index to access:");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            Console.WriteLine("Value at index " + index + ": " + array[index]);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by Zero - " + ex.Message);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: Index Out of Range - " + ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
