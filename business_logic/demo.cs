using System;
using System.Collections.Generic;
namespace business_logic{
    public class demo{
        public Dictionary<int, int> data1(){                 //dictionary to store flight number with availability of seats
            Dictionary<int, int> seats = new Dictionary<int, int>();     
            seats.Add(1120, 21); 
            seats.Add(1121, 06); 
            seats.Add(1122, 01); 
            seats.Add(1123, 00); 
            seats.Add(1124, 13); 
            seats.Add(1125, 17);
            seats.Add(1126, 33); 
            seats.Add(1127, 02); 
            seats.Add(1128, 00);
            seats.Add(1129, 09);
            return seats;
        }
        public Dictionary<int, string> data2(){                //dictionary to store booking id with booking status
            Dictionary<int, string> bookings = new Dictionary<int, string>();
            bookings.Add(121, "pending"); 
            bookings.Add(129, "confirmed"); 
            bookings.Add(131, "confirmed"); 
            bookings.Add(175, "cancelled"); 
            bookings.Add(198, "pending"); 
            bookings.Add(103, "confirmed"); 
            bookings.Add(339, "confirmed"); 
            bookings.Add(441, "confirmed"); 
            bookings.Add(559, "confirmed"); 
            bookings.Add(771, "cancelled");
            return bookings;
        }
        public Dictionary<int, int> data3(){                   //dictionary to store booking id with flight number
            Dictionary<int, int> flightbook = new Dictionary<int, int>();
            flightbook.Add(121, 1120); 
            flightbook.Add(129, 1121); 
            flightbook.Add(131, 1122); 
            flightbook.Add(175, 1123); 
            flightbook.Add(198, 1124); 
            flightbook.Add(103, 1125); 
            flightbook.Add(339, 1126); 
            flightbook.Add(441, 1127); 
            flightbook.Add(559, 1128); 
            flightbook.Add(771, 1129);
            return flightbook;
        }
    }
}
