using System;

namespace ConsoleApp
{
    // Employee class inherits IQuittable interface
    public class Employee : IQuittable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload == operator to compare by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, emp2))
                return true;

            if ((object)emp1 == null || (object)emp2 == null)
                return false;

            return emp1.Id == emp2.Id;
        }

        // Overload != operator (paired with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Recommended overrides for == and !=
        public override bool Equals(object obj)
        {
            var other = obj as Employee;
            if (other == null)
                return false;

            return this.Id == other.Id;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        // Implementation of IQuittable's Quit() method
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the company.");
        }
    }
}
