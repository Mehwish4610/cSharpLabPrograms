using System;

class Fp3
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            if (string.IsNullOrEmpty(inputString))
            {
                throw new ArgumentException("Input string cannot be null or empty.");
            }

            Console.WriteLine("List of all substrings:");
            Substrings(inputString);
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

    static void Substrings(string inputString)
    {
        for (int i = 0; i < inputString.Length; i++)
        {
            for (int j = i + 1; j <= inputString.Length; j++)
            {
                string substring = inputString.Substring(i, j - i);
                Console.WriteLine(substring);
            }
        }
    }
}
