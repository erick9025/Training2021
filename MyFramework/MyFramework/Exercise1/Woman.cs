using System;
using System.Collections.Generic;

namespace Inheritance.Exercise1
{
    public class Woman : Human
    {
        public static int womenCreated = 0;

        public Woman(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
            womenCreated++;
        }

        public void GoShopping(double budget)
        {
            //Do something
        }
    }
}
