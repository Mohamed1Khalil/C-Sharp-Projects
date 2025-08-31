using System;

class Program
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt for package weight
        Console.WriteLine("Please enter the package weight:");
        float weight = float.Parse(Console.ReadLine()); // Convert input to float

        // Check if weight exceeds 50
        if (weight > 50)
        {
            // Display error and end program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit the program
        }

        // Prompt for package width
        Console.WriteLine("Please enter the package width:");
        float width = float.Parse(Console.ReadLine()); // Convert input to float

        // Prompt for package height
        Console.WriteLine("Please enter the package height:");
        float height = float.Parse(Console.ReadLine()); // Convert input to float

        // Prompt for package length
        Console.WriteLine("Please enter the package length:");
        float length = float.Parse(Console.ReadLine()); // Convert input to float

        // Check if total dimensions exceed 50
        float dimensionTotal = width + height + length;
        if (dimensionTotal > 50)
        {
            // Display error and end program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit the program
        }

        // Calculate the quote: (width * height * length * weight) / 100
        float quote = (width * height * length * weight) / 100;

        // Display the quote as a dollar amount formatted to two decimal places
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}
