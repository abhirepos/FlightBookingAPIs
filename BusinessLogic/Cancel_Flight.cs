using System;
using System.Collections.Generic;
namespace FlightBookingAPIs.BusinessLogic
{
    public class Cancel_Flight
    {
        public int Pending_Status(string status)
        {
            if (status == "Confirmed")
            return 1;
            else if (status == "Pending")
            return 0;
            else
            return -1;
        }

        public int available_seats(int seats, int cancelled_seats)
        {
            return (seats+cancelled_seats);
        }
        public String extractFlightName(String n)
        {
            return (n.Substring(0,2));

        }
        public int extractSeats(String n)
        {
            String s= (n.Substring(3,3));
            return(Int16.Parse(s)) ;
        }

        
        public static void main(string [] args)
        {   String flightId="";
            int search =0; 

            //assuming we have the following outputs
            string [] BookingIDs = new string[]{"CDS001","CMS030","CDS004"}  ;  //FlightNo + S + No. of seats
            string [] BookingStatus = new string[]{"Confirmed","Pending","Cancelled"};
            string [] FlightName = new String []{"CD","CM","CL"};
            int [] availableSeats = new int []{45,45,7};
            IDictionary<String, Int16> Flights = new Dictionary<String, Int16>()
                                            {
                                                {"CD", 45},
                                                { "CM",45},
                                                {"CL",7},
                                            };
            Cancel_Flight ob = new Cancel_Flight();
            
            for (int count =0;count< BookingIDs.Length; count++)
            {
                if(ob.Pending_Status(BookingStatus[count])==1)
                {
                    flightId = ob.extractFlightName(BookingIDs[count]);
                    for (search = 0; search<FlightName.Length;search++)
                    {
                        if (flightId.Equals(FlightName[search]))
                        {
                                availableSeats[search]=availableSeats[search]+(ob.extractSeats(BookingIDs[count]));
                        }
                    }

                }
                else if (ob.Pending_Status(BookingStatus[count])==0)
                {
                    Console.WriteLine("Booking cancelled");

                }
                else
                {
                    Console.WriteLine("Booking already cancelled");
                }
            }
    }
}
}