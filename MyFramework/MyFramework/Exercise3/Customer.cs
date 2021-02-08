using System;
namespace Inheritance.Exercise3
{
    public sealed class Customer : Person
    {
        public string PassportNumber { get; private set; }

        private Customer()
        {

        }

        public Customer(string passportNumber, string firstName, string lastName, Countries country, DateTime DateOfBirth, Gender gender, string middleName = null)
            :base(firstName, lastName, country, DateOfBirth, gender, middleName)
        {
            this.PassportNumber = passportNumber;
        }

        public override void PrintPersonDetails()
        {
            int age = this.DateOfBirth.GetAge();

            Console.WriteLine("");
            Console.WriteLine("Passport Number: " + PassportNumber);
            Console.WriteLine("First Name: " + FirstName);
            if (!string.IsNullOrEmpty(MiddleName))  Console.WriteLine("Middle Name: " + MiddleName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Gender: " + Gender.GetDescription());
            Console.WriteLine("Country: " + string.Join("|", Country, Country.GetDescription()));
            Console.WriteLine("Date of Birth: " + DateOfBirth.ToString("MMMM dd yyyy"));
            Console.WriteLine("Age: " + age);
            Console.WriteLine("");
        }

        public string GetFullName()
        {
            try
            {
                return string.Join(" ", this.FirstName, this.MiddleName, this.LastName).Replace("  ", " ");
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
