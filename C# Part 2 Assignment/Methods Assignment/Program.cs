using System;

namespace MathOperationApp
{
    // This is a custom class containing our method
    class MathHandler
    {
        // A void method that takes two integers as parameters
        public void DoMath(int number1, int number2)
        {
            // Perform a math operation on the first integer (e.g., square it)
            int result = number1 * number1;

            // Display the result of the math operation
            Console.WriteLine("The square of the first number is: " + result);

            // Display the second integer
            Console.WriteLine("The second number is: " + number2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathHandler mathHandler = new MathHandler();

            // Call the method using positional arguments
            mathHandler.DoMath(4, 7);

            // Call the method using named parameters
            mathHandler.DoMath(number1: 9, number2: 3);

            // Wait for user input before closing (optional)
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
