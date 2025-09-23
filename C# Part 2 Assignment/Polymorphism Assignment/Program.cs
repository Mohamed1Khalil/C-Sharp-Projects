using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object
            Employee emp = new Employee
            {
                Id = 202,
                FirstName = "Mohamed",
                LastName = "Khalil"
            };

            // Use polymorphism: assign Employee to IQuittable type
            IQuittable quittableEmployee = emp;

            // Call Quit() method on the interface-type object
            quittableEmployee.Quit();

            // Wait for user input before exiting (optional)
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
