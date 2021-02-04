using System;
using NUnit.Framework; //Mac Exclusive
//MSTest -- microsoft windows
//XUnit -- multiplatform

namespace Inheritance.Exercise2
{
    public class AxosCreditCard : CreditCard, ICard
    {
        ///...................................................................................................
        ///....................................... ATTRIBUTES / VARIABLES ....................................
        ///...................................................................................................

        //Static Attributes (CLASS level)
        public static int cardCounter = 0;

        //Attributes (OBJECT/INSTANCE level)
        string cardStatus = "Active";

        ///...................................................................................................
        ///............................................. CONSTRUCTOR .........................................
        ///...................................................................................................

        public AxosCreditCard(string owner, string cardNumber, double lineOfCredit, CardNetworks network)
        {
            //Assertions / Validations (Use of NUnit Library/Nuget)
            Assert.AreEqual(16, cardNumber.Length, "Card number should be 16 digits");
            Assert.IsTrue(lineOfCredit > 0.00, "Line Of Credit must be greater than zero");

            this.cardHolder = owner;
            this.cardNumber = cardNumber;
            this.lineOfCredit = lineOfCredit;
            this.cardNetwork = network;
            cardCounter++;
        }

        ///...................................................................................................
        ///.................................. OVERRIDE PARENT METHODS / BEHAVIORS ............................
        ///...................................................................................................

        public override void Withdraw(double amountWithdrawn)
        {
            Console.WriteLine($"New Withdraw :: {GetCardMask()}:");
            Console.WriteLine($"   <--$-- ▅   {amountWithdrawn.ToString("C")}{Environment.NewLine}");//https://fsymbols.com/signs/square/
            base.Withdraw(amountWithdrawn);
        }

        public override void Deposit(double amountDeposited)
        {
            Console.WriteLine($"New Deposit :: {GetCardMask()}:");
            Console.WriteLine($"   --$--> ▅   {amountDeposited.ToString("C")}{Environment.NewLine}");
            base.Deposit(amountDeposited);
        }

        ///...................................................................................................
        ///......................................... NEW METHODS / BEHAVIORS .....................................
        ///...................................................................................................

        public void BuySomething(double transactionAmount, string authNumber, string concept)
        {
            //Assertions or Validations
            //Validate and if FAIL, stop program and print a message
            Assert.IsTrue(transactionAmount > 0.00, "Transaction amount must be greater than zero");
            Assert.IsFalse(string.IsNullOrEmpty(authNumber), "Authorization number can NOT be null/empty");
            Assert.IsFalse(string.IsNullOrEmpty(concept) && concept.Length >= 7, "Concept can NOT be null/empty and must have at least 7 chars");

            base.Withdraw(transactionAmount);
            Console.WriteLine($"New purchase @ {GetCardMask()}:");
            Console.WriteLine($"      {authNumber}");
            Console.WriteLine($"      {concept}");
            Console.WriteLine($"      {transactionAmount.ToString("C")}{Environment.NewLine}");
        }

        public void PrintBalance()
        {
            DateTime dNow = DateTime.Now;
            string dateFormat = dNow.ToString("yyyy MMM dd @ HH:mm:ss");

            Console.WriteLine($"<<{GetCardMask()}>>");
            //ToString("C") gives currency format 1325.17 --> $1,1325.17
            Console.WriteLine($"Your current balance as of {dateFormat} is: ${this.balance.ToString("N")}"); //Way parameterized
            Console.WriteLine(string.Empty);

            return; //Code after return won't be executed
            Console.WriteLine("Your current balance as of " + dateFormat + " is: $" +this.balance.ToString("N")); //Part by part
            //This won't be executed
            //This won't be executed neither
        }

        public override void PrintCardDetails()
        {
            Console.WriteLine($"----------------------------------- {GetCardMask()} -----------------------------------");
            Console.WriteLine("     - Card Holder: " + this.cardHolder);
            Console.WriteLine("     - Card Number: " + this.cardNumber);
            Console.WriteLine("     - Status: " + this.cardStatus);
            Console.WriteLine("     - Balance: $" + this.balance.ToString("N"));
            Console.WriteLine("     - Available Credit: $" + this.availableCredit.ToString("N"));
            Console.WriteLine("     - Line of Credit: $" + this.lineOfCredit.ToString("N"));
            Console.WriteLine("     - Card Network: " + this.cardNetwork);
            Console.WriteLine("     - Has Additionals: " + this.hasAdditionals.ToString().ToUpper());
            Console.WriteLine($"------------------------------------------------------------------------------------------");
        }

        private string GetCardMask()
        {
            //index  0000000000111111
            //index  0123456789012345
            //       4789151511561156 <--sample card number (16 length)

            //4789 1515 1156 1156
            //Visa **1156

            //substring obtains a specif portion from an original string

            string lastFourDigits = cardNumber.Substring(cardNumber.Length - 4, 4);
            string cardMask = cardNetwork.ToString() + " **" + lastFourDigits;

            return cardMask;
        }
    }
}
