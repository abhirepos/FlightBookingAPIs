using System.Xml.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
namespace FlightBookingAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]   
    public class UserBookingController:ControllerBase
    {
       public  UserBookingController()
        {

        }
        [HttpGet("{id}")]
        public Model.User Get(int id)
        {
            Data.Userdec pi= new Data.Userdec();
            Dictionary<int,Model.User> l1= pi.check();
            return l1[id];
            
             
            

        }
    }
}