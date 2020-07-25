
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



namespace FlightBookingAPIs.Business_logic
{
    
   public class BookBusiness
    {
        private IUserRepo _repo;

        enum payment{Paid,DeniedByBank,CancelledByUser,Failed}
       
      public BookBusiness(IUserRepo repo)
       {
          _repo=repo;
       }
     

           
        public Book mock(int pay, int flight_no, bool avail)
        {
           
        
            
            if (avail)
            {
                if (pay == (int)payment.Paid)
                {
                    return new Book
                    {
                        status = true,
                        message = " your booking has been confirmed",
                        booking = "confirmed"
                    };
                }
                else if(pay!=(int)payment.CancelledByUser)
                {
                    return new Book
                    {
                        status = false,
                        message = " your booking is pending",
                        booking = "pending",
                        
                    };
                }
                else
                {
                     return new Book
                    {
                        status = false,
                        message = " your booking is cancelled",
                        booking = "cancelled"
                    };
                }


            }
            else
            {
                return new Book
                {
                    status = false,
                    message = "",
                    booking = ""
                
                };
            }

        }


    }
}