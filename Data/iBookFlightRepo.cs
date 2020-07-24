using System.Collections.Generic;
using FlightBookingAPIs.Models;

namespace FlightBookingAPIs.Data
{
    public interface IBookFlightRepo
    {
        IEnumerable<BookFlight> GetAppFlight();

        BookFlight GetFlightById (int id);

    }
}