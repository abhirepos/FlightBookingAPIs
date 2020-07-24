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
    public class flightAvailabilityController : ControllerBase{
        [HttpGet("{flight_no}")]

        public Models.flightAvailability Get(int flight_no){
            int flightnum=flight_no;

            business_logic.flightAvailability ob=new business_logic.flightAvailability();
            int value=ob.available(flightnum);
            if(value>0){
                return new Models.flightAvailability{
                        isSuccessful=true,
                        message="Seats Available",
                        availableSeats=value,
                };
            }
            else if(value==0){
                return new Models.flightAvailability{
                        isSuccessful=true,
                        message="No Seats Available",
                        availableSeats=0,
                };
            }
            else{
                return new Models.flightAvailability{
                    isSuccessful=false,
                    message="Invalid Flight number",
                };
            }
        }
    }
}
    /*

            if(!flight_seat.ContainsKey(flight_no)){
                return new Models.flightAvailability{
                    isSuccessful=false,
                    message="Invalid Flight number",
                };
            }
            else{
                if(flight_seat[flight_no]>0){
                    return new Models.flightAvailability{
                        isSuccessful=true,
                        message="Seats Available",
                        availableSeats=flight_seat[flight_no],
                    };
                }
                else{
                    return new Models.flightAvailability{
                        isSuccessful=true,
                        message="No Seats Available",
                        availableSeats=0,
                    };
                }
            }
        }
    }
}*/