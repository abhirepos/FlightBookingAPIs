
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using FlightBookingAPIs.Data;
using FlightBookingAPIs.Model;
using Newtonsoft.Json;
using System.Linq;

namespace FlightBookingAPIs.Business_logic
{
  
    public class UserBookingBusiness
    {
        private IUserRepo _repo;

        public UserBookingBusiness(IUserRepo repo) => _repo = repo;

        
        public User mock(int id)
        {
            
            
             Dictionary<int,User> user = _repo.GetAll()
                                      .ToDictionary(x => x.Key, x => x.Value);
            return user[id];
                                     
            
             
            

        }
    }
}