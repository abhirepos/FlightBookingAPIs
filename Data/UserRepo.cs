using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using FlightBookingAPIs.Model;

namespace FlightBookingAPIs.Data

{
    public class UserRepo:IUserRepo
    {
      
      
    
       
      

        public IEnumerable<KeyValuePair<int,User>> GetAll()
        {
         var userlist= new Dictionary<int,User>();
         
          
           userlist.Add( 1, new User{
               BookingId=300,
                BookingDate=DateTime.Today,
                paystat = 1,
                Flight_no=1234,
                BookingStatus=true,
               Deptairname="India",
               arrairname="Australia",
                arrdate="10/08/2020",
                Deptdate="03/09,2020",
                aircharge= 100.00,
                message="confirmed"
           }
           );


         userlist.Add(2, new User {
                BookingId=100,
                BookingDate=DateTime.Today,
                paystat=1,
                Flight_no=1235,
               BookingStatus=true,
               Deptairname="India",
               arrairname="England",
                arrdate="10/08/2020",
                Deptdate="03/09,2020",
                aircharge= 1000.00,
                message="confirmed"
               });
            userlist.Add(3, new User{
                BookingId=200,
                BookingDate=DateTime.Today,
                Flight_no=1230,
                paystat=2,
              BookingStatus = false,
               Deptairname="India",
               arrairname="Africa",
                arrdate="10/08/2020",
                Deptdate="03/09,2020",
                aircharge= 100.00,
                message="invalid"
               });
            userlist.Add(4,new User{
                BookingId=400,
                BookingDate=DateTime.Today,
                paystat=3,
                Flight_no=1237,
              BookingStatus= false,
               Deptairname="India",
               arrairname="Australia",
                arrdate="10/08/2020",
                Deptdate="03/09,2020",
                aircharge= 100.00,
                message="Cancelled"
                });
          
          return userlist;

         
        }

        public IEnumerable<KeyValuePair<int,int>> GetSeat()
        {
             var fl_no= new Dictionary<int,int>();
           fl_no.Add(1234,5);
          fl_no.Add(1235,5);
          fl_no.Add(1236,5);
          fl_no.Add(1237,5);
          return fl_no;
        }

        public IEnumerable<KeyValuePair<int,int>> GetBooking()
        {
          var Bk_id= new Dictionary<int,int>();
         Bk_id.Add(300,1);
         Bk_id.Add(100,2);
         Bk_id.Add(200,3);
         Bk_id.Add(400,4);
          return Bk_id;
        }
    }
}