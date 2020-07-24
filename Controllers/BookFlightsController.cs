using System.Collections.Generic;
using FlightBookingAPIs.Data;
using FlightBookingAPIs.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlightBookingAPIs.Controllers
{
    //api/bookFlights
    [Route("api/bookFlights")]
    [ApiController]
    public class BookFlightsController : ControllerBase
    {
        private readonly MockFlightRepo _repository = new MockFlightRepo();
        //GET api/bookFlights
        [HttpGet]
        public ActionResult <IEnumerable<BookFlight>> GetAllFlights()
        {
            var flightItems = _repository.GetAppFlight();

            return Ok(flightItems);        
        }

        //GET api/bookFlights/{id}
        [HttpGet("{id}")]
        public ActionResult <BookFlight> GetFlightById(int id)
        {
            var flightItems = _repository.GetFlightById(id);
          
            return Ok(flightItems);
        }
    }
}