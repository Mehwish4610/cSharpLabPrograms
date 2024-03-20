using System;

class Fp6
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the number of rows for Floyd's Triangle:");
            int numRows = int.Parse(Console.ReadLine());

            if (numRows <= 0)
            {
                throw new ArgumentException("Number of rows must be greater than 0.");
            }

            int[][] floydsTriangle = GenerateFloydsTriangle(numRows);

            Console.WriteLine("Floyd's Triangle:");

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(floydsTriangle[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
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

    static int[][] GenerateFloydsTriangle(int numRows)
    {
        int[][] triangle = new int[numRows][];

        int count = 1;
        for (int i = 0; i < numRows; i++)
        {
            triangle[i] = new int[i + 1];
            for (int j = 0; j <= i; j++)
            {
                triangle[i][j] = count++;
            }
        }

        return triangle;
    }
}
