using System;
namespace Inheritance.Exercise2
{
    public class DebitCard : Card
    {
        public override void PrintCardDetails()
        {
            Console.WriteLine("Printing 'DebitCard' details below...");
        }
    }
}
