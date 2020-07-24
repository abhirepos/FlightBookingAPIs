using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FlightBookingAPIs.Models;

namespace FlightBookingAPIs.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class cancelBookingController : ControllerBase{
        [HttpGet("{id}")]
        public Models.cancelBooking get(int id){
            business_logic.cancelBooking ob=new business_logic.cancelBooking();
            String status=ob.cancel(id);

            if(status=="Confirmed"){
                status="Cancelled";
                return new Models.cancelBooking{
                    isSuccessful= true,
                    message="Booking Cancelled",
                };
            }
            else if(status=="Pending"){
                status="Cancelled";
                return new Models.cancelBooking{
                    isSuccessful= true,
                    message="Booking Cancelled",
                };
            }
            else if(status=="Cancelled"){
                return new Models.cancelBooking{
                    isSuccessful= true,
                    message="Booking is already Cancelled",
                };
            }
            else{
                return new Models.cancelBooking{
                    isSuccessful= false,
                    message="Invalid Booking number",
                };
            }
        }
    }
}