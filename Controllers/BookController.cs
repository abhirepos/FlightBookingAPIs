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

            [HttpGet("{custID_flight_pay}")]
        public Model.Book Get(int custID, int flight, int pay)
        {
            
            AvailabilityController Av = new AvailabilityController();
            Model.Availability  avail =Av.Get( flight);
        
            
            if (avail.status)
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
                        fl=flight
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
                    message = avail.message,
                    booking = avail.message,
                    fl=flight
                };
            }

        }


    }
}