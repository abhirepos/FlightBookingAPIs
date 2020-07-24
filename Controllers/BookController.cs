using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;



namespace FlightBookingAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
      enum payment{Paid,DeniedByBank,CancelledByUser,Failed}
       
      public BookController()
       {

       }
     

           
        public Model.Book Post([FromBody]Model.flight_no flight)
        {
           int pay= flight.pay;
           int flight_no=flight.Flight_No;
           bool avail=flight.avail;
        
            
            if (avail)
            {
                if (pay == (int)payment.Paid)
                {
                    return new Model.Book
                    {
                        status = true,
                        message = " your booking has been confirmed",
                        booking = "confirmed"
                    };
                }
                else if(pay!=(int)payment.CancelledByUser)
                {
                    return new Model.Book
                    {
                        status = false,
                        message = " your booking is pending",
                        booking = "pending",
                        
                    };
                }
                else
                {
                     return new Model.Book
                    {
                        status = false,
                        message = " your booking is cancelled",
                        booking = "cancelled"
                    };
                }


            }
            else
            {
                return new Model.Book
                {
                    status = false,
                    message = "",
                    booking = ""
                
                };
            }

        }


    }
}