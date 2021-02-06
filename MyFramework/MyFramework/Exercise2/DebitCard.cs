using MyFramework.Exercise3_Karen;
using System;
namespace Inheritance.Exercise2
{
    public class DebitCard : Card
    {
        public override void PrintCardDetails()
        {
            Printer.Print("Printing 'DebitCard' details below...");
        }
    }
}
