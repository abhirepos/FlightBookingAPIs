using System;
using System.Collections.Generic;
namespace FlightBookingAPIs.business_logic{
    public class cancelBooking{
        public String cancel(int id){
            Models.userBooking ob=new Models.userBooking();
            flightAvailability ob1=new flightAvailability();
            if(ob.bookingStatus=="Confirmed"){
                int flight_no=ob.Flight_no;
                return("Confirmed");
            }
            else if(ob.bookingStatus=="Pending"){
                return ("Pending");
            }
            else if(ob.bookingStatus=="Cancelled"){
                return ("Cancelled");
            }
            else{
                return("Invalid");
            }
        }
    }
}