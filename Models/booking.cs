using System;
namespace FlightBookingAPIs.Models{
    public class booking{
        public bool isSuccessful {get;set;}
        public string status {get;set;}
        public string message {get;set;}
        public int id{get;set;}
        public int flight{get;set;}
        
    }
}