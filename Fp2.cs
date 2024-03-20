using System;

class Fp2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Armstrong numbers between 1 to 1000:");

        for (int num = 1; num <= 1000; num++)
        {
            if (IsArmstrong(num))
            {
                Console.WriteLine(num);
            }
        }
    }

    static bool IsArmstrong(int number)
    {
        int originalNumber = number;
        int sum = 0;
        int numberOfDigits = (int)Math.Floor(Math.Log10(number)) + 1;

        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, numberOfDigits);
            number /= 10;
        }

        return sum == originalNumber;
    }
}
