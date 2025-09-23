using System;

namespace ConsoleApp
{
    // Employee class with Id, FirstName, and LastName properties
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading the == operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, or both are same instance, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null, but not both, return false
            if ((object)emp1 == null || (object)emp2 == null)
                return false;

            // Return true if Ids are equal
            return emp1.Id == emp2.Id;
        }

        // Overloading the != operator (must be paired with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // It's recommended to override Equals() and GetHashCode() when overloading ==
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
    }
}
