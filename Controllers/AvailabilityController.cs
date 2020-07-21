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
    
    [Route("[controller]")]
    [ApiController]
    public class AvailabilityController : ControllerBase
    {


       public AvailabilityController()
       {
          
       }

     


        [HttpGet("{flight_no}")]
        public Model.Availability Get(int flight_no)
        {
            Dictionary<int, int> fl = new Dictionary<int, int>();
            fl.Add(1234, 5);
            fl.Add(1235, 5);
            fl.Add(1236, 5);
            fl.Add(1237, 5);


           
            if (fl.ContainsKey(flight_no))
            {
                int v = fl[flight_no];
                if (v > 0)
                {

                    return new Model.Availability
                    {
                        status = true,
                        message = "Seat available",
                        seat = v,
                        

                    };
                }
                else
                {
                    return new Model.Availability
                    {
                        status = false,
                        message = "seats not available",
                        seat = v,
                        

                    };
                }

            }
            else
            {
                return new Model.Availability
                {
                    status = false,
                    message = "invalid no",
                  

                };
            }

        }
    }
}