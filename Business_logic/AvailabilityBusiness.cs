
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using FlightBookingAPIs.Data;
using FlightBookingAPIs.Library;
namespace FlightBookingAPIs.Business_logic
{
    

    public class AvailabilityBusiness
    {
        private IUserRepo _repo;

        public AvailabilityBusiness(IUserRepo repo) => _repo = repo;




        
        public Availability mock(int flight_no)
        {
           

            
            Dictionary<int, int> fl = _repo.GetSeat()
                                      .ToDictionary(x => x.Key, x => x.Value);
           
            if (fl.ContainsKey(flight_no))
            {
                int v = fl[flight_no];
                if (v > 0)
                {

                    return new Availability
                    {
                        status = true,
                        message = "Seat available",
                        seat = v,
                        

                    };
                }
                else
                {
                    return new Availability
                    {
                        status = false,
                        message = "seats not available",
                        seat = v,
                        

                    };
                }

            }
            else
            {
                return new Availability
                {
                    status = false,
                    message = "invalid no",
                  

                };
            }

        }
    }
}