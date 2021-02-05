using Inheritance.Exercise2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyFramework.SampleMethods;

namespace ErickRun
{
    [TestClass]
    public class TestCreditCards
    {
        /// <summary>
        /// Author: Erick Jiménez
        /// </summary>

        [TestMethod, TestCategory("Financial")]
        public void Exercise_CreditCards()
        {
            //declare and instantiate object (2 actions on a SINGLE LINE)
            AxosCreditCard card1 = new AxosCreditCard("Erick Jiménez", "4792012304560789", 50000, CardNetworks.Mastercard);

            //declare object ONLY
            AxosCreditCard card2;

            //instantiate object ONLY
            card2 = new AxosCreditCard("Dua Lipa", "4143101304560796", 999999, CardNetworks.AmericanExpress);

            card2.Deposit(1500);

            card1.PrintBalance();
            card1.BuySomething(1754.17, "ABC1234xyz", "Walmart Retail");
            card1.Withdraw(45.83);
            card1.PrintCardDetails();
            card1.BuySomething(10, "QJXR9414", "Amazon Marketplace");
            card1.PrintCardDetails();

            card2.PrintCardDetails();

            AxosCreditCard card3 = new AxosCreditCard("Karen González", "4792012304560010", 999999, CardNetworks.Visa);
            Console.WriteLine("How many cards created so far: " + AxosCreditCard.cardCounter);

            card3.BuySomething(1.99, "MSFT134", "Microsoft Verification");
            card3.PrintCardDetails();
        }

        [TestMethod, TestCategory("Fibonacci")]
        public void Exercise_Fibonacci()
        {
            Console.WriteLine(SampleMethods.Fibonacci(10));
        }
    }
}
