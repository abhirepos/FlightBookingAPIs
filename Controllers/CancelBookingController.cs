
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using FlightBookingAPIs.Data;
using FlightBookingAPIs.Model;
using FlightBookingAPIs.Library;
using FlightBookingAPIs.Business_logic;

namespace FlightBookingAPIs.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class CancelBookingController:ControllerBase
    {
        private IUserRepo _repo;

        public CancelBookingController(IUserRepo repo)
        {
              _repo=repo;
        }
       [HttpGet("{bookid}")]
        public Book Get(int bookid)
        {
            CancelBookingBusiness cancelBooking= new CancelBookingBusiness(_repo);
            return cancelBooking.mock(bookid);
        
        
        
                
        }
           
        }

    }

        
 
  
