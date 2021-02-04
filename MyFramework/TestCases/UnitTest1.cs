using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ErickRun
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool foundNum = false;
            int num = 1;
            int[] A = new int[] { 1, 3, 6, 4, 1, 2 };
            List<int> myList = A.ToList().OrderBy(x => x).ToList();

            while (!foundNum)
            {
                if (!myList.Contains(num))
                {
                    foundNum = true;
                }
                else
                {
                    num++;
                }
            }

            System.Console.WriteLine("UNO " + num);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool foundNum = false;
            int num = 1;
            int[] A = new int[] { 1, 2, 3 };
            List<int> myList = A.ToList().OrderBy(x => x).ToList();

            while (!foundNum)
            {
                if (!myList.Contains(num))
                {
                    foundNum = true;
                }
                else
                {
                    num++;
                }
            }

            System.Console.WriteLine("DOS " + num);
        }

        [TestMethod]
        public void TestMethod3()
        {
            bool foundNum = false;
            int num = 1;
            int[] A = new int[] { -1, -3 };
            List<int> myList = A.ToList().OrderBy(x => x).ToList();

            while (!foundNum)
            {
                if (!myList.Contains(num))
                {
                    foundNum = true;
                }
                else
                {
                    num++;
                }
            }

            System.Console.WriteLine("TRES " + num);
        }

        [TestMethod]
        public void ForTest()
        {
            DateTime myDate = DateTime.Today;
            string dayOfWeek = string.Empty;
            string year = "";

            Console.WriteLine("hacer un programa que imprima todos los sabados y domingos que aun no suceden del 2021");

            for (int x = 0; x <= 365; x++)
            {
                myDate = myDate.AddDays(1);
                dayOfWeek = myDate.ToString("dddd");
                year = myDate.ToString("yyyy");

                if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                {
                    if (year == "2021")
                    {
                        Console.WriteLine(myDate.ToString("yyyy MMMM dd dddd"));
                    }
                }
            }
        }

        [TestMethod]
        public void Karen_Jan25()
        {
            DateTime todaysDate = DateTime.Today;
            string dayComplete;
            string year;

            Console.WriteLine("While test");

            int x = 0;
            //for (int x = 0; x <= 365; x = x + 1)
            while (x <= 365)
            {
                todaysDate = todaysDate.AddDays(1);
                dayComplete = todaysDate.ToString("dddd");
                year = todaysDate.ToString("yyyy");



                if ((dayComplete == "Saturday" || dayComplete == "Sunday") && year == "2021")
                {
                    Console.WriteLine(todaysDate.ToString("yyyy,MMMM,dd, dddd"));
                }
                x++;
            }

            //ToDo

            //thisIsCalledCamelCase--> variables y objetos
            //ThisIsCalledPascalCase--> clases y metodos
        }

        [TestMethod]
        public void Pending()
        {
            
        }
    }
}
