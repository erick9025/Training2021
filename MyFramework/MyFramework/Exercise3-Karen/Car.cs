using System;
namespace MyFramework.Exercise3_Karen
{
    public class Car : GroundTransport, ITransport
    {
        

        public Car(string brand, string nameOfModel, int ageModel, string color, double cost)
        {
            this.brand = brand;
            this.nameOfModel = nameOfModel;
            this.ageModel = ageModel;
            this.color = color;
            this.cost = cost;
        }

        public override void Move(int distance)
        {
            this.kmTraveled = kmTraveled+distance;
            Printer.Print("moving " + distance + " Km");
        }

        public Car Reverse(int distance)
        {
            this.reversedMeters = reversedMeters + distance;
            Printer.Print("reversing " + distance + " meters");
            return this;
        }

        public override void PrintCarDetails()
        {
            Printer.Print("");
            Printer.Print("Brand: " +brand);
            Printer.Print("Model: " +nameOfModel);
            Printer.Print("Age Model: " +ageModel);

            Printer.Print("Color: " +color);
            Printer.Print("Cost: " +cost.ToString("C"));
            Printer.Print("Km traveled: " +kmTraveled);
            Printer.Print("Meters reversed: " + reversedMeters);
        }
    } 
}