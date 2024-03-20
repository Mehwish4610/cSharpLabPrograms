using System;
using System.IO;

class Fp7
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the path of the source text file:");
            string sourceFilePath = Console.ReadLine();

            Console.WriteLine("Enter the path of the destination text file:");
            string destinationFilePath = Console.ReadLine();

            // Check if source file exists
            if (!File.Exists(sourceFilePath))
            {
                throw new FileNotFoundException("Source file not found.");
            }

            // Read the content of the source file
            string fileContent = File.ReadAllText(sourceFilePath);
            Console.WriteLine("Content of source file '" + sourceFilePath + "':\n" + fileContent + "\n");

            // Write the content to the destination file
            File.WriteAllText(destinationFilePath, fileContent);

            Console.WriteLine("File copied successfully.");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
