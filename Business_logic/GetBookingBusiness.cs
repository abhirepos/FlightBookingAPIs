using System.Net.NetworkInformation;
using Newtonsoft.Json;
using System.Xml.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using FlightBookingAPIs.Model;
using FlightBookingAPIs.Data;

namespace FlightBookingAPIs.Business_logic
{
    
    public class GetBookingBusiness
    {
        private IUserRepo _repo;

        enum stat{confirmed,pending,cancelled};

        public GetBookingBusiness(IUserRepo userRepo) => _repo = userRepo;

       
        public IEnumerable<KeyValuePair<int,User>> mock(string id)
        {
          
                var values = _repo.GetAll();
                Dictionary<int,User> temp= new Dictionary<int, User>();
                foreach(KeyValuePair<int,User> us in values)
                {
                    if(us.Value.message==id)
                    temp.Add(us.Key,us.Value);
                }
               return temp;

        }

        
    }
}