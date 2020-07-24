using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FlightBookingAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookFlightController : ControllerBase
    {
        [HttpGet("{CustomerID_Flight_PayamentStat_Seats}")]
        public Model.BookModel get(string CustomerID,string Flight,int PaymentStat,int Seats )
        {
            BusinessLayer.BookFlight ob = new BusinessLayer.BookFlight();
            int AvailableSeats = ob.Book(CustomerID,Flight,PaymentStat,Seats);
            if(AvailableSeats == -99)
            {
                return new Model.BookModel
                {
                    isSuccessful=false,
                    Message= "Cannot confirm the booking due to unavailability of seats",
                    CustomID = CustomerID, 
                };
            }
            else
            {
                if(AvailableSeats>0)
                {
                    return new Model.BookModel
                    {
                        isSuccessful= true,
                        BookStatus= "Confirmed",
                        Message= "Your Booking has been Confirmed",
                        BookID = CustomerID+Flight+"S"+Seats,
                        BookedFlight = Flight,
                    };
                }
                else if(AvailableSeats==-2)
                {
                    return new Model.BookModel
                    {
                        isSuccessful= true,
                        BookStatus= "Pending",
                        Message= "Your Booking is Pending",
                        BookID = CustomerID+Flight+"S"+Seats,
                    };
                }
                else
                {
                    return new Model.BookModel
                    {
                        isSuccessful= false,
                        BookStatus= "Cancelled",
                        Message= "Your Booking has been Cancelled",
                    };
                }
            }
        }
    }
}