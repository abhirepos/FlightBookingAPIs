using System;
using System.Collections.Generic;
namespace FlightBookingAPIs.BusinessLogic{
    public class FlightAvailability{
        Dictionary<int, int> flight_seat = new Dictionary<int, int>();
        public int available(int flight_no){
            flight_seat.Add(1120, 17);
            flight_seat.Add(1121, 0);
            flight_seat.Add(1123, 1);

            if(!flight_seat.ContainsKey(flight_no)){
                return -1;
                }
            else{
                if(flight_seat[flight_no]>0){
                    return flight_seat[flight_no];
                }
                else{
                    return 0;
                }
            }
        }
    }
}