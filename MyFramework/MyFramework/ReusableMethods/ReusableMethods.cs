using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ReusableMethods
{
    public class ReusableMethods
    {
        //If parameter not equal to something is MANDATORY
        //If parameter is equal to something is OPTIONAL
        public void IsNumberWithinRange(int myNum, int firstNum = 5, int lastNum = 15)
        {
            string range = "[" + firstNum + " to " + lastNum + "]";

            //Console.WriteLine("My num is: " + myNum + ".");
            Console.WriteLine($"My num is: {myNum}.");

            if (myNum >= firstNum && myNum <= lastNum)
            {
                Console.WriteLine("YES in... " + range);
            }
            else
            {
                Console.WriteLine("NO in..." + range);
            }

            Console.WriteLine("");
        }
    }
}
