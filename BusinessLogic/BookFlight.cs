using Microsoft;
using System;

namespace FlightBookingAPIs.BusinessLogic
{
    public class BusinessRules_FlightBooking
    {  
        
        public int payment(String PaymentStatus, int available )
        {
            if (available<0)
                return -1;
                
            else 
            {
                if (PaymentStatus == "Paid")
                {
                    
                    available = available - 1;
                    return 1;
                }
                else
                {
                    
                    return 0;
                }
            }
        }

        

        public static void main(String args)
        {
            String [] CusID = new String[]{"A001","A002","A003"};
            String [] PaymentDemo = new String[]{"Paid","Pending","Paid"};
            BusinessRules_FlightBooking ob = new BusinessRules_FlightBooking();
            String [] Confirmed= new String[3];
            int c =0;
            int available = 6;
            for (int count = 0 ; count<= CusID.Length; count++)
            {
                if(ob.payment(PaymentDemo[count],available)==-1)
                    Console.WriteLine("Cannot Confirm the booking due to unavailability of seats");
                else if(ob.payment(PaymentDemo[count],available)==1)
                {
                    Console.WriteLine("Confirmed");
                    Confirmed[c++]=CusID[count];
                    available = available-1;
                }
                else
                {
                    Console.WriteLine("Pending");
                }
            }
            

        }
        
    }
    
        
        


    
}