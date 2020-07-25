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
    [ApiController]
    [Route("[controller]")]
   public class BookController : ControllerBase
    {
        private IUserRepo _repo;

       
      public BookController(IUserRepo repo)
       {
              _repo=repo;
       }
     

           
        public Book Post([FromBody]flight_no flight)
        {
           int pay= flight.pay;
           int flight_no=flight.Flight_No;
           bool avail=flight.avail;

           BookBusiness bookBusiness= new BookBusiness(_repo);
           return bookBusiness.mock(pay,flight_no,avail);

        
            
            

        }


    }
}