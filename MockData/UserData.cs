using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace FlightBookingAPIs.MockData{
    public class UserData{
      public  Dictionary<int,Models.userBooking> users= new Dictionary<int,Models.userBooking>();
      public   Dictionary<int,int>Flight_Seat = new Dictionary<int, int>();
        public Dictionary<int,Models.userBooking> data(){
            Models.userBooking user1= new Models.userBooking{
                bookingId=121,
                isSuccessful=true,
                bookingDate=DateTime.Today,
                paymentStatus=1,
                Flight_no=2120,
                bookingStatus="Confirmed",
                departure="Mumbai",
                arrival="Delhi",
                arr_date_time="15-08-2020, 23:20",
                dep_date_time="16-08-2020, 01:50",
                fareCharge= 1000.00,
                message="Booking is Confirmed"
            };
            users.Add(1,user1);
            Models.userBooking user2= new Models.userBooking{
                bookingId=122,
                isSuccessful=true,
                bookingDate=DateTime.Today,
                paymentStatus=3,
                Flight_no=2121,
                bookingStatus="Pending",
                departure="Kolkata",
                arrival="Chennai",
                arr_date_time="03-10-2020, 10:10",
                dep_date_time="03-10-2020, 12:20",
                fareCharge= 1200.00,
                message="Booking is Pending"
            };
            users.Add(2,user2);
            Models.userBooking user3= new Models.userBooking{
                bookingId=123,
                isSuccessful=true,
                bookingDate=DateTime.Today,
                paymentStatus=1,
                Flight_no=2120,
                bookingStatus="Confirmed",
                departure="Mumbai",
                arrival="Delhi",
                arr_date_time="06-01-2021, 15:10",
                dep_date_time="06-01-2021, 17:20",
                fareCharge= 565.00,
                message="Booking is Confirmed"
            };

            users.Add(3,user3);
            return users;
        }
        public Dictionary<int,int> FlightSeatMock()
        {
            Flight_Seat.Add(2120,54);
            Flight_Seat.Add(2121,65);
            return Flight_Seat;
        }
    }
}