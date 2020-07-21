using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
namespace FlightBookingAPIs.Services
{
    public class Userdec
    {
      public  Dictionary<int,Model.User> l1= new Dictionary<int,Model.User>();
       
        public Dictionary<int,Model.User> check()
            {
             
            Model.User us1= new Model.User{
                BookingId=300,
                BookingDate=DateTime.Today,
                paystat = 1,
                Flight_no=1234,
                
               Deptairname="India",
               arrairname="Australia",
                arrdate="10/08/2020",
                Deptdate="03/09,2020",
                aircharge= 100.00,
                

            };
            l1.Add(1,us1);
             Model.User us2= new Model.User{
                BookingId=100,
                BookingDate=DateTime.Today,
                paystat=1,
                Flight_no=1235,
               
               Deptairname="India",
               arrairname="England",
                arrdate="10/08/2020",
                Deptdate="03/09,2020",
                aircharge= 1000.00,
                

            };
            l1.Add(2,us2);
             Model.User us3= new Model.User{
                BookingId=200,
                BookingDate=DateTime.Today,
                Flight_no=1230,
                paystat=2,
              
               Deptairname="India",
               arrairname="Africa",
                arrdate="10/08/2020",
                Deptdate="03/09,2020",
                aircharge= 100.00,
               

            };
            l1.Add(3,us3);
             Model.User us4= new Model.User{
                BookingId=400,
                BookingDate=DateTime.Today,
                paystat=3,
                Flight_no=1237,
              
               Deptairname="India",
               arrairname="Australia",
                arrdate="10/08/2020",
                Deptdate="03/09,2020",
                aircharge= 100.00,
                
               

            };
            l1.Add(4,us4);
         return l1;
        }
    }
}