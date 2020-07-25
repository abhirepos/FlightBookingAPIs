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
using FlightBookingAPIs.Data;
using FlightBookingAPIs.Library;
using FlightBookingAPIs.Business_logic;

namespace FlightBookingAPIs.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class AvailabilityController : ControllerBase
    {
        private IUserRepo _repo;

        public AvailabilityController(IUserRepo repo) => _repo = repo;




        [HttpGet("{flight_no}")]
        public Availability Get(int flight_no)
        {
           

           AvailabilityBusiness availabilityBusiness= new AvailabilityBusiness(_repo);
           return availabilityBusiness.mock(flight_no);
            
           
           
           

        }
    }
}