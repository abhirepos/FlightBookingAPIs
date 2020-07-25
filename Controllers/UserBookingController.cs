using System.Xml.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using FlightBookingAPIs.Data;
using FlightBookingAPIs.Model;
using FlightBookingAPIs.Business_logic;
using Newtonsoft.Json;
namespace FlightBookingAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]   
    public class UserBookingController:ControllerBase
    {
        private IUserRepo _repo;

        public UserBookingController(IUserRepo repo) => _repo = repo;
        [HttpGet("{id}")]
        public User Get(int id)
        {
           UserBookingBusiness userBooking=new UserBookingBusiness(_repo);
           return userBooking.mock(id);
            
             
            

        }
    }
}