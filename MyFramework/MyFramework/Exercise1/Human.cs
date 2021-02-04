using System;
namespace Inheritance
{
    //BEHAVIORS
    //ATTRIBUTES
    //CAN NOT INSTANCE FROM AN ABSTRACT CLASS (CREATE OBJECT)
    public abstract class Human : IMammal
    {
        //Attributes (Variable)
        public string gender;
        public DateTime dateOfBirth;
        public string firstName;
        public string lastName;
        public int age;

        public void Breath()
        {

        }

        public void Move()
        {

        }
        
    }
}
