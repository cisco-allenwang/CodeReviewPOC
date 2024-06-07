using System;

namespace Test
{
    public class Person
    {
        // Private fields
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;

        // Public properties
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be null or whitespace.");
                }
                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be null or whitespace.");
                }
                _lastName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Date of birth cannot be in the future.");
                }
                _dateOfBirth = value;
            }
        }

        // Constructor
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        // Methods
        public int GetAge()
        {
            int age = DateTime.Now.Year - _dateOfBirth.Year;
            if (DateTime.Now < _dateOfBirth.AddYears(age))
            {
                age--;
            }
            return age;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {GetAge()}";
        }
    }
}
