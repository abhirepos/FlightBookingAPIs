using System;

namespace FlightBookingAPIs.Model
{
    public class FlightAvailabilityModel
    {
        public bool isSuccessful{get;set;}
        public int availableSeats{get;set;}
        public string Message{get;set;}
    }
}