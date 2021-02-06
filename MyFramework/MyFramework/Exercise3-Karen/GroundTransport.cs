using System;
namespace MyFramework.Exercise3_Karen
{
    public abstract class GroundTransport : ITransport

    {
        public int reversedMeters = 0;
        public string brand;
        public string nameOfModel;
        public int ageModel;
        public string color;
        public double cost;
        public int kmTraveled;

        public int PassengerCapacity {get; set;} 

        public abstract void Move(int distance);
        public abstract void PrintCarDetails();      
    }
}
