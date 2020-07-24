using System.Collections.Generic;
using FlightBookingAPIs.Models;

namespace FlightBookingAPIs.Data
{
    public class MockFlightRepo : IBookFlightRepo
    {
        public IEnumerable<BookFlight> GetAppFlight()
        {
            var bookFlights = new List<BookFlight>
            {
                new BookFlight{ID = 0, HowTo="Book a flight", Line="Slect number", Platform="Internet"},
                new BookFlight{ID = 1, HowTo="Book a flight1", Line="Slect number1", Platform="Internet1"},
                new BookFlight{ID = 2, HowTo="Book a flight2", Line="Slect number2", Platform="Internet2"}
            };

            return bookFlights;
        }

        public BookFlight GetFlightById(int id)
        {
            return new BookFlight{ID = 0, HowTo="Book a flight", Line="Slect number", Platform="Internet"};
        }
    }
}