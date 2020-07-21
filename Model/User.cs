using System;
namespace FlightBookingAPIs.Model
{
    
    public class User
    {
        
        public int BookingId{get;set; }
        

        public DateTime BookingDate{get;set;}

       public int paystat{get;set;}

        public  int Flight_no{get;set;}
      
       

        public bool BookingStatus {get;set;}
          public string Deptairname{get;set;}
        public string arrairname{get;set;}
        public string Deptdate{get;set;}
        public string arrdate{get;set;}

        public double aircharge{get;set;}
         public double tax => .15*aircharge;
         public double total => aircharge+tax;

        
        public string message {get;set;}


    }
}