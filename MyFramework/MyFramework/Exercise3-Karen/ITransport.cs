using System;
namespace MyFramework.Exercise3_Karen
{
    public interface ITransport
    {
        int PassengerCapacity { get; set;} //es una propiedad por el get y el set
        void Move(int distance);
    }
}
