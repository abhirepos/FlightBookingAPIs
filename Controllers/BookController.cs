
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace FlightbookingAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]   
     public class BookController : ControllerBase
    {
        public BookController()
        {

        }
       
        [HttpGet]
        public Model.Book Get()
        {
        List<int > Fl_no= new List<int>();
        Fl_no.Add(1234);
        Fl_no.Add(1235);
        int customer_id = 123;
        Controllers.AvailabilityController Av= new Controllers.AvailabilityController{
            Flight_no=1234
        };
      Model.Availability avail=Av.Get();
      string payment ="paid";
        if(avail.status)
        {
           if(payment == "paid")
           {
           return  new Model.Book{
               status=true,
               message=" your booking has been confirmed",
               booking= "confirmed"
           };
           }
           else 
           {
                return  new Model.Book{
               status=false,
               message=" your booking is pending",
               booking= "pending"
           };
           }

        }
        else
        {
            return  new Model.Book{
               status=false,
               message=" There are no seats available",
               booking= ""
           };
        }

        }

        
    }
}