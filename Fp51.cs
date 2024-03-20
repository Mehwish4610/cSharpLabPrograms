using System;

class Fp51
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the number of rows for Pascal's Triangle:");
            int numRows = int.Parse(Console.ReadLine());

            if (numRows <= 0)
            {
                throw new ArgumentException("Number of rows must be greater than 0.");
            }

            int[][] pascalsTriangle = GeneratePascalsTriangle(numRows);

            Console.WriteLine("Pascal's Triangle:");

            for (int i = 0; i < numRows; i++)
            {
                // Add spaces to the left of each row to form a pyramid
                for (int j = 0; j < numRows - i - 1; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(pascalsTriangle[i][j].ToString().PadLeft(4, ' '));
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

    static int[][] GeneratePascalsTriangle(int numRows)
    {
        int[][] triangle = new int[numRows][];

        for (int i = 0; i < numRows; i++)
        {
            triangle[i] = new int[i + 1];
            triangle[i][0] = 1; // First element in each row is 1
            triangle[i][i] = 1; // Last element in each row is 1

            for (int j = 1; j < i; j++)
            {
                // Sum of the two numbers above in the previous row
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }
        }

        return triangle;
    }
}
