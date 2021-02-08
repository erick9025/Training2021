//using NUnit.Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ReusableMethods
{
    public class Car
    {
        double cost;

        public Car(double cost)
        {
            Assert.IsTrue(cost >= 1000, "Cost should be equal or greater than 1000");
        }
    }
}
