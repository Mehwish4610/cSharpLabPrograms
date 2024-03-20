using System;

class Fp1
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Welcome to the Simple Arithmetic Calculator!");

            // Read operator
            Console.WriteLine("Enter the operator (+, -, *, /, %):");
            char operation = char.Parse(Console.ReadLine());

            // Read operands
            Console.WriteLine("Enter the first operand:");
            double operand1;
            if (!double.TryParse(Console.ReadLine(), out operand1))
            {
                throw new FormatException("Invalid input for first operand. Please enter a valid number.");
            }

            Console.WriteLine("Enter the second operand:");
            double operand2;
            if (!double.TryParse(Console.ReadLine(), out operand2))
            {
                throw new FormatException("Invalid input for second operand. Please enter a valid number.");
            }

            // Perform operation
            double result = 0;

            switch (operation)
            {
                case '+':
                    result = operand1 + operand2;
                    break;
                case '-':
                    result = operand1 - operand2;
                    break;
                case '*':
                    result = operand1 * operand2;
                    break;
                case '/':
                    if (operand2 == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                    result = operand1 / operand2;
                    break;
                case '%':
                    result = operand1 % operand2;
                    break;
                default:
                    throw new ArgumentException("Invalid operator.");
            }

            Console.WriteLine("Result: " + result);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
