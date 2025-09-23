using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first Employee object
            Employee emp1 = new Employee
            {
                Id = 101,
                FirstName = "Mohamed",
                LastName = "Khalil"
            };

            // Create second Employee object
            Employee emp2 = new Employee
            {
                Id = 101,
                FirstName = "Khalil",
                LastName = "Mohamed"
            };

            // Compare the two employees using overloaded ==
            if (emp1 == emp2)
            {
                Console.WriteLine("Employees are equal (based on Id).");
            }
            else
            {
                Console.WriteLine("Employees are NOT equal.");
            }

            // Compare using !=
            if (emp1 != emp2)
            {
                Console.WriteLine("Employees are different.");
            }
            else
            {
                Console.WriteLine("Employees are the same (based on Id).");
            }

            // Wait for user input before closing (optional)
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
