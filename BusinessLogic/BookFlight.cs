using System;
using System.Collections.Generic;
namespace FlightBookingAPIs.BusinessLogic{
    public class BookFlight{
        public enum payStatus{
            paid, deniedByBank, pending, cancelled
        }
        public int book (int id, int flight_no, int paymentStatus){
            FlightAvailability ob=new FlightAvailability();
            int value=ob.results(flight_no);
            if (value==0){
                return -1;
            }
            else{
                if(paymentStatus==(int)payStatus.paid && value>0){
                    return value;
                }
                else if(paymentStatus!=(int)payStatus.cancelled && value>0){
                    return -2;
                }
                else{
                    return 0;
                }
            }
        }
    }
}
