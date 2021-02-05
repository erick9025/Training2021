using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.SampleMethods
{
    public static class SampleMethods
    {
        public static string Fibonacci(int howManyNumbers = 10)
        {
            int previousNumber = 0;
            int newNumber = 1;
            int fibonacci;
            string returnFibonacci = "0 1";

            Console.WriteLine($"Calculating 'Fibonacci' series of {howManyNumbers} numbers");

            for (int iterator = 1; iterator < howManyNumbers; iterator++)
            {
                // position  1 2 3 4 5 6 7 8  9  10 11
                //-------------------------------------
                // fibonacci 0 1 1 2 3 5 8 13 21 34 55

                fibonacci = previousNumber + newNumber;

                //Recalculate both numbers
                previousNumber = newNumber;
                newNumber = fibonacci;

                //Append to (output) string
                if(iterator == 1) //First iteration ONLY (exception case)
                    returnFibonacci = fibonacci + " " + newNumber;
                else //All remaining iterations
                    returnFibonacci = returnFibonacci + " " + fibonacci;
            }

            return returnFibonacci;
        }
    }
}
