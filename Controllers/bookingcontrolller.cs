using System.Reflection;
using System.Xml.Schema;
using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace FlightBookingAPIs.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class bookingController : ControllerBase{
        
        [HttpGet("{id_flightno_paymentStatus}")]
        public Models.booking get(int id, int flight_no, int paymentStatus){
            BusinessLogic.BookFlight ob=new BusinessLogic.BookFlight();
            int seats=ob.book(id,flight_no,paymentStatus);
            if (seats==-1){
                return new Models.booking{
                    isSuccessful=false,
                    message= "Cannot confirm the booking due to unavailability of seats",
                    id=id,
                };
            }
            else{
                if(seats>0){
                    return new Models.booking{
                        isSuccessful= true,
                        status= "Confirmed",
                        message= "Booking Confirmed",
                    };
                }
                else if(seats==-2){
                    return new Models.booking{
                        isSuccessful= true,
                        status= "Pending",
                        message= "Booking Pending",
                    };
                }
                else {
                    return new Models.booking{
                        isSuccessful= false,
                        status= "Cancelled",
                        message= "Booking is Cancelled",
                    };
                }
            }
        }
    }
}