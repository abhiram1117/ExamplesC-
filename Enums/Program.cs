using System;

class Program
{
    enum DaysOfWeek
    {
        Sunday,    
        Monday,    
        Tuesday,   
        Wednesday, 
        Thursday,  
        Friday,    
        Saturday   
    }

    static void Main()
    {
        Console.WriteLine("Enter a day of the week:");
        string userInput = Console.ReadLine();

        if (Enum.TryParse<DaysOfWeek>(userInput, ignoreCase: true, out DaysOfWeek userDay))
        {
            switch (userDay)
            {
                case DaysOfWeek.Sunday:
                    Console.WriteLine("It's a holiday!");
                    break;
                case DaysOfWeek.Monday:
                case DaysOfWeek.Tuesday:
                case DaysOfWeek.Wednesday:
                case DaysOfWeek.Thursday:
                    Console.WriteLine("It's a working day.");
                    break;
                case DaysOfWeek.Friday:
                    Console.WriteLine("Weekend is almost here!. It's a working day");
                    break;
                case DaysOfWeek.Saturday:
                    Console.WriteLine("It's weekend!");
                    break;
                default:
                    Console.WriteLine("Invalid day entered.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid day of the week.");
        }
    }
}