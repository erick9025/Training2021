using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Inheritance.Exercise3
{
    public class Flight
    {
        //Public properties
        public int SeatCount { get; private set; }
        public int SeatsTaken { get; private set; }
        public string FlightNumber { get; private set; }
        public string CityFrom { get; set; }
        public string CityTo { get; set; }
        public Airlines Airline { get; set; }
        public Airplanes Airplane { get; set; }
        public Dictionary<int, Customer> SeatInfo { get { return seatInfo; } }

        //Static field
        public static int flightsCreated = 0;

        //Private ENCAPSULATED fields
        private Dictionary<int, Customer> seatInfo = new Dictionary<int, Customer>();

        //Private NOT encapsulated fields
        private List<Customer> _passengersList = new List<Customer>();

        //Constructors
        private Flight() { } //Protect default constructor to prevent creating a Flight object with no information

        public Flight(Airlines airline, Airplanes airplane, int flightNumberId, string departingFrom, string arrivingTo)
        {
            this.Airline = airline;
            this.Airplane = airplane;
            this.CityFrom = departingFrom;
            this.CityTo = arrivingTo;

            //Validate flight id and generate flight number
            Assert.IsTrue(flightNumberId >= 100, "Flight id should be greater or equal than 100");
            this.FlightNumber = airline.GetDescription().Split('|').Last() + flightNumberId;

            //Calculate seat count and generate SeatInfo dictionary
            SeatCount = AirportInfo.aircraftsSeatsCount[airplane];

            for (int x = 1; x <= SeatCount; x++)
            {
                SeatInfo[x] = null;
            }

            flightsCreated++;
        }

        public void AssignSeat(int seatNumber, Customer customer)
        {
            Customer assignedCustomer = SeatInfo[seatNumber];

            if(assignedCustomer == null)
            {
                ChangeSeat(seatNumber, customer);
                SeatsTaken++;
            }
            else
            {
                Assert.Fail($"Seat #{seatNumber} is already taken by: {customer.GetFullName()}");
            }
        }

        public void ChangeSeat(int seatNumber, Customer customer)
        {
            Console.WriteLine($"Assigned seat #{seatNumber} to: {customer.GetFullName()}");
            SeatInfo[seatNumber] = customer;

            //Store client in list
            _passengersList.Add(customer);
        }

        public void PrintSeatInformation(bool printTakenSeatsOnly = true)
        {
            Console.WriteLine("");

            //Demo Karen 3 possible syntax for below if
            if(printTakenSeatsOnly)
            {
                PrintAlreayTakenSeats();
            }
            else
            {
                PrintAllSeats();
            }

            Console.WriteLine("");
        }

        private void PrintAlreayTakenSeats()
        {
            Console.WriteLine("Printing only taken seats already...");
            foreach (var seat in SeatInfo)
            {
                if (seat.Value != null)
                    Console.WriteLine("     " + seat.Key + " --> " + seat.Value.GetFullName());
            }
        }

        private void PrintAllSeats()
        {
            Console.WriteLine("Printing all seats...");
            foreach(var seat in SeatInfo)
            {
                if (seat.Value != null)
                {
                    Console.WriteLine("     " + seat.Key + " --> " + seat.Value.GetFullName());
                }
                else
                {
                    Console.WriteLine("     " + seat.Key + " --> ???");
                }
            }
        }

        public void PrintAllPassengersInfo()
        {
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine("Printing all passenger information from below flight");
            PrintFlightInfo();

            foreach (var passenger in _passengersList)
            {
                passenger.PrintPersonDetails();
            }

            Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

        public void PrintFlightInfo()
        {
            Console.WriteLine("   - Flight number: " + FlightNumber);
            Console.WriteLine("   - Airline: " + Airline.GetDescription().Split('|').First());
            Console.WriteLine("   - Airplane: " + Airplane.GetDescription());
            Console.WriteLine("   - From: " + CityFrom);
            Console.WriteLine("   - To: " + CityTo);
            Console.WriteLine("   - Total seats count: " + SeatCount);
            Console.WriteLine("   - Total passengers count: " + SeatsTaken);
        }
    }
}
