using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
namespace FlightBookingAPIs.BusinessLogic{

    public interface IUserBooking
    {
        public Boolean checkFlight(int flightNo);
        //List <Models.userBooking> data(Dictionary<int, Models.userBooking>details,int ID);
        public double Charges (double fare, double tax);
    }
    public class UserBooking : IUserBooking
    {
        
        public Boolean checkFlight(int flightNo)
        {
            MockData.UserData ob = new MockData.UserData();
            Dictionary <int,int> availableFlight = ob.FlightSeatMock();
            if((availableFlight.ContainsKey(flightNo))== false)
            return false;
            else
            return true;
        }
        public double Charges (double fare,double tax)
        {
            return(fare*(1+(tax/100.0)));

        }


        }
    }


