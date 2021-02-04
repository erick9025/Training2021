using System;
namespace Inheritance.Exercise2
{
    public interface ICard
    {
        //double balance; //Not possible

        void Withdraw(double amountWithdrawn);

        void Deposit(double amountDeposited);
    }
}
