
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
    
    
    public class CancelBookingBusiness
    {
        private IUserRepo _repo;

        public CancelBookingBusiness(IUserRepo repo)
        {
          _repo=repo;
        }
      
        public Book mock(int bookid)
        {
            
        
         
         Dictionary<int,int> cancl= _repo.GetBooking()
                                      .ToDictionary(x => x.Key, x => x.Value);
         Dictionary<int,int> fl= _repo.GetSeat()
                                      .ToDictionary(x => x.Key, x => x.Value);
         Dictionary<int,User> usr= _repo.GetAll()
                                      .ToDictionary(x => x.Key, x => x.Value);
         int userid=cancl[bookid];
    
          
                if(usr[userid].message=="confirmed")
                {

                    fl[usr[userid].Flight_no]++;
                   return new Book
                {
                    status = true,
                    message = "cancelled",
                   
                  

                };
                }
                else if(usr[userid].message=="pending")
                {
                  return new Book
                {
                    status = true,
                    message = "cancelled",
                    
                  

                };
                }
                else
                {
                    return new Book
                    {
                        status = false,
                    message = "Invalid",
              
                    };
                }
            }
           
        }

    }




 
  
