using System.Collections.Generic;
using FlightBookingAPIs.Model;

namespace FlightBookingAPIs.Data
{
    public interface IUserRepo
    {
        IEnumerable<KeyValuePair<int,User>> GetAll();
        IEnumerable<KeyValuePair<int, int>> GetSeat();
        IEnumerable<KeyValuePair<int, int>> GetBooking();
    }
}

