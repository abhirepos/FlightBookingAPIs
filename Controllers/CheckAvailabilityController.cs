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


namespace FlightBookingAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckAvailabilityController : ControllerBase
    {
        [HttpGet("{Flight}")]
        public Model.FlightAvailabilityModel Get(string Flight)
        {
            BusinessLayer.FlightAvailability FAM = new BusinessLayer.FlightAvailability();
            int Flightseat = FAM.available(Flight);
            if(Flightseat>0)
            {
                return new Model.FlightAvailabilityModel
                {
                    isSuccessful = true,
                    Message ="Seats Available",
                    availableSeats = Flightseat,
                };
            }
            else if(Flightseat==0)
            {
                return new Model.FlightAvailabilityModel
                {
                        isSuccessful = true,
                        Message = "No Seats Available",
                        availableSeats = 0,
                };
            }
            else
            {
                return new Model.FlightAvailabilityModel
                {
                    isSuccessful=false,
                    Message="Invalid Flight number",
                };
            }
        }
    }
}