using System;

class ExceptionHandlingExample
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Division Calculator");

            Console.Write("Enter the numerator: ");
            int numerator = GetNumberFromUser();

            Console.Write("Enter the denominator: ");
            int denominator = GetNumberFromUser();
            int result = PerformDivision(numerator, denominator);

            Console.WriteLine($"Result: {numerator} / {denominator} = {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Invalid input. Please enter a valid number. Details: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
    static int GetNumberFromUser()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    static int PerformDivision(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return numerator / denominator;
    }
}