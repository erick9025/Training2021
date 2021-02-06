using MyFramework.Exercise3_Karen;
using System;
namespace Inheritance.Exercise2
{
    public class CreditCard : Card
    {        
        //Attributes (OBJECT/INSTANCE level)
        protected bool hasAdditionals = false;
        protected double lineOfCredit;
        protected double availableCredit { get { return lineOfCredit + balance; } }

        public CreditCard() //constructor (we can get rid of since it is default)
        {
        }

        public override void PrintCardDetails()
        {
            Printer.Print("");
            Printer.Print("Printing 'CreditCard' details below...");

            //ToDo pending implementation
        }
    }
}
