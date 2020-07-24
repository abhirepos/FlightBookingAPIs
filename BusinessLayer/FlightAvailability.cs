using System;
using System.Collections.Generic;
using FlightBookingAPIs;

namespace FlightBookingAPIs.BusinessLayer
{
    public class FlightAvailability
    {
        //public Dictionary<string, int> Availability = new Dictionary<string, int>();
        public int available(string Flight)
        {
            Dictionary<string, int> Availability = new Dictionary<string, int>();
            Availability.Add("F001", 17);
            Availability.Add("F002", 0);
            Availability.Add("F003", 1);
            Availability.Add("F004", 10);
            Availability.Add("F005", 5);

            if(!Availability.ContainsKey(Flight))
            {
                return -1;
            }
            else
            {
                if(Availability[Flight]>0)
                {
                    return Availability[Flight];
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}