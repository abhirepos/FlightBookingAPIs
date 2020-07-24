using System;
namespace FlightBookingAPIs.Models{
    public class userBooking{
        public int bookingId{get;set;}
        public bool isSuccessful{get;set;}
        public DateTime bookingDate{get;set;}
        public int paymentStatus{get;set;}
        public  int Flight_no{get;set;}
        public string bookingStatus {get;set;}
        public string departure{get;set;}
        public string arrival{get;set;}
        public string dep_date_time{get;set;}
        public string arr_date_time{get;set;}
        public double fareCharge{get;set;}
        public string message{get;set;}
        public double tax=>0.15*fareCharge;
        public double totalCharge=>fareCharge+tax;
    }
}