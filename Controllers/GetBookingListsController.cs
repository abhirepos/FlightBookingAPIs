using System.Net.NetworkInformation;
using Newtonsoft.Json;
using System.Xml.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using FlightBookingAPIs.Model;
using FlightBookingAPIs.Data;
using FlightBookingAPIs.Business_logic;

namespace FlightBookingAPIs.Controllers
{
     [ApiController]
    [Route("[controller]")]
    public class GetBookingLists:ControllerBase
    {
        private IUserRepo _repo;

        enum stat{confirmed,pending,cancelled};

        public GetBookingLists(IUserRepo userRepo) => _repo = userRepo;

        [HttpGet("{id}")]
        public string Get(string id)
        {
           
               GetBookingBusiness getBooking=new GetBookingBusiness(_repo);
               var values= getBooking.mock(id);
               string json= JsonConvert.SerializeObject(values,Formatting.Indented);
                return json;
               

        }

        
    }
}