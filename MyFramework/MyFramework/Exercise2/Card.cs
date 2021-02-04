using System;
namespace Inheritance.Exercise2
{
    public abstract class Card : ICard
    {
        public string cardHolder;
        public string cardNumber;
        public int expirationMonth;
        public int expirationYear;
        public double balance = 0.00;
        public CardNetworks cardNetwork = CardNetworks.Mastercard;
        public string Notes { get; set; }

        public virtual void Withdraw(double amountWithdrawn)
        {
            balance = balance - amountWithdrawn;
        }

        public virtual void Deposit(double amountDeposited)
        {
            balance = balance + amountDeposited;
        }

        public abstract void PrintCardDetails();
    }

    //Catalog, force user to select one of a list of specific values
    public enum CardNetworks
    {
        Visa,
        Mastercard,
        AmericanExpress
    }
}
