using System;
using NUnit.Framework; //Mac Exclusive
using MyFramework.Exercise3_Karen;
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
            Printer.Print($"New Withdraw :: {GetCardMask()}:");
            Printer.Print($"   <--$-- ▅   {amountWithdrawn.ToString("C")}{Environment.NewLine}");//https://fsymbols.com/signs/square/
            base.Withdraw(amountWithdrawn);
        }

        public override void Deposit(double amountDeposited)
        {
            Printer.Print($"New Deposit :: {GetCardMask()}:");
            Printer.Print($"   --$--> ▅   {amountDeposited.ToString("C")}{Environment.NewLine}");
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
            Printer.Print($"New purchase @ {GetCardMask()}:");
            Printer.Print($"      {authNumber}");
            Printer.Print($"      {concept}");
            Printer.Print($"      {transactionAmount.ToString("C")}{Environment.NewLine}");
        }

        public void PrintBalance()
        {
            DateTime dNow = DateTime.Now;
            string dateFormat = dNow.ToString("yyyy MMM dd @ HH:mm:ss");

            Printer.Print($"<<{GetCardMask()}>>");
            //ToString("C") gives currency format 1325.17 --> $1,1325.17
            Printer.Print($"Your current balance as of {dateFormat} is: ${this.balance.ToString("N")}"); //Way parameterized
            Printer.Print(string.Empty);

            return; //Code after return won't be executed
            Printer.Print("Your current balance as of " + dateFormat + " is: $" +this.balance.ToString("N")); //Part by part
            //This won't be executed
            //This won't be executed neither
        }

        public override void PrintCardDetails()
        {
            Printer.Print($"----------------------------------- {GetCardMask()} -----------------------------------");
            Printer.Print("     - Card Holder: " + this.cardHolder);
            Printer.Print("     - Card Number: " + this.cardNumber);
            Printer.Print("     - Status: " + this.cardStatus);
            Printer.Print("     - Balance: $" + this.balance.ToString("N"));
            Printer.Print("     - Available Credit: $" + this.availableCredit.ToString("N"));
            Printer.Print("     - Line of Credit: $" + this.lineOfCredit.ToString("N"));
            Printer.Print("     - Card Network: " + this.cardNetwork);
            Printer.Print("     - Has Additionals: " + this.hasAdditionals.ToString().ToUpper());
            Printer.Print($"------------------------------------------------------------------------------------------");
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
