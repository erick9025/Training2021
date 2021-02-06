using Inheritance.Exercise2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFramework.Exercise3_Karen;
using System;

namespace ErickRun
{
    [TestClass]
    public class TestCars
    {

        [TestMethod, TestCategory("Carritos")]
        public void Exercise_Carritos()
        {
            Car car1 = new Car("Nissan", "Tsuru", 2000, "black", 80000);
            Car car2 = new Car("Honda", "Civic", 2019, "white", 180000);
            Car car3 = new Car("Mazda", "mazda3", 2021, "blue", 280000);

            car1.Move(15);
            car1.Move(10);
            car1.Move(8);
            car1.Move(15);

            car2.Move(25);          
            car2.Move(12);

            car3.Move(60);
            car3.Move(6);

            car1.PrintCarDetails();
            car2.PrintCarDetails();
            car3.PrintCarDetails();

            //Method call chaining because method returns a "Car" object
            car1
                .Reverse(11)
                .Reverse(22)
                .Reverse(33)
                .Reverse(44);

            car2
                .Reverse(5)
                .Reverse(12);

            car3
                .Reverse(3)
                .Reverse(6)
                .Reverse(4);

            car1.PrintCarDetails();
            car2.PrintCarDetails();
            car3.PrintCarDetails();

            Printer.Print(car1.reversedMeters.ToString());
        }

        //EXPLICIT DECLARATION
        //public void Run(); 
        //public int myAge;

        //IMPLICIT DECLARATION (made automatically by CPU)
        // void Run(); <--- internal for methods
        // int myAge;  <--- private for attributes fields or variables

        //public - access by anywhere where there is reference
        //internal - access by anywhere within the same project/assembly
        //protected - access by that class and all its child classes
        //private - access by that class ONLY
    }
}
