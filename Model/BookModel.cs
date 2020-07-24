using System;

namespace FlightBookingAPIs.Model
{
    public class BookModel
    {
        public bool isSuccessful{get;set;}
        public string CustomID{get;set;}
        public string BookID{get;set;}
        public string BookStatus{get;set;}
        public string BookedFlight{get;set;}
        public string Message{get;set;}
    }
}