using System;
namespace Inheritance.Exercise3
{
    public class Person
    {
        public string FirstName { get; protected set; }
        public string MiddleName { get; protected set; }
        public string LastName { get; protected set; }
        public Countries Country { get; protected set; }
        public DateTime DateOfBirth { get; protected set; }
        public Gender Gender { get; protected set; }

        protected Person ()
        {

        }

        public Person(string firstName, string lastName, Countries country, DateTime DateOfBirth, Gender gender, string middleName = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
            this.DateOfBirth = DateOfBirth;
            this.Gender = gender;

            //Only assign middleName when is not null
            if(!string.IsNullOrEmpty(middleName))
            {
                this.MiddleName = middleName;
            }
        }

        public virtual void PrintPersonDetails()
        {
            int age = this.DateOfBirth.GetAge();

            Console.WriteLine("");
            Console.WriteLine("First Name: " + FirstName);
            if (!string.IsNullOrEmpty(MiddleName))  Console.WriteLine("Middle Name: " + MiddleName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Gender: " + Gender.GetDescription());
            Console.WriteLine("Country:" + Country.GetDescription());
            Console.WriteLine("Date of Birth: " + DateOfBirth.ToShortDateString());
            Console.WriteLine("Age: " + age);
            Console.WriteLine("");
        }
    }
}
