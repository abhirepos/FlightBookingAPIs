using System.Reflection;
using System.Xml.Schema;
using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using FlightBookingAPIs.Data;

namespace FlightBookingAPIs.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class CancelBookingController:ControllerBase
    {
        public CancelBookingController()
        {

        }
       [HttpGet("{bookid}")]
        public Model.Book Get(int bookid)
        {
            
        
         Userdec us = new Userdec();
         Dictionary<int,int> cancl= us.cancel();
         Dictionary<int,int> fl= us.seats();
         Dictionary<int,Model.User> usr= us.check(); 
         int userid=cancl[bookid];
    
          
                if(usr[userid].message=="confirmed")
                {

                    fl[usr[userid].Flight_no]++;
                   return new Model.Book
                {
                    status = true,
                    message = "cancelled",
                   
                  

                };
                }
                else if(usr[userid].message=="pending")
                {
                  return new Model.Book
                {
                    status = true,
                    message = "cancelled",
                    
                  

                };
                }
                else
                {
                    return new Model.Book
                    {
                        status = false,
                    message = "Invalid",
              
                    };
                }
            }
           
        }

    }

        
 
  
