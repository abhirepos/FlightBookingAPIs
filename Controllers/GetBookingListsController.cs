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

namespace FlightBookingAPIs.Controllers
{
     [ApiController]
    [Route("[controller]")]
    public class GetBookingLists:ControllerBase
    {
        enum stat{confirmed,pending,cancelled};
        
        public  GetBookingLists()
    {
        
    }
  
        [HttpGet("{id}")]
        public string Get(string id)
        {
           Userdec pi= new Userdec();
         Dictionary<int,Model.User> l1=pi.check();   
            Dictionary<int,Model.User> l2= new Dictionary<int,Model.User> ();
                 foreach(KeyValuePair<int,Model.User> values in l1)
                 {
                    if(values.Value.message==id)

                     l2.Add(values.Key,values.Value);
                 }
                string json= JsonConvert.SerializeObject(l2,Formatting.Indented);
                return json;


        }

        
    }
}