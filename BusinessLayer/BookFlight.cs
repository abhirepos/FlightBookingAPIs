using System;
using FlightBookingAPIs;

namespace FlightBookingAPIs.BusinessLayer
{
    public class BookFlight
    {
        public enum PaymentStatus
        {
            paid, deniedByBank, pending, cancelledbyuser
        }
        public int Book(string CustomerID,string Flight,int PaymentStat,int seats)
        {
            BusinessLayer.FlightAvailability FA = new BusinessLayer.FlightAvailability();
            int isAvail = FA.available(Flight);
            if (isAvail<=0)
                return -99;
            else    
            { 
                if (PaymentStat==(int)PaymentStatus.paid && (isAvail-seats)>=0)
                    return isAvail;
                else if ((PaymentStat==(int)PaymentStatus.deniedByBank || PaymentStat==(int)PaymentStatus.pending) && (isAvail-seats)>=0)
                    return -2;
                else
                    return 0;
            }
        }
    }
}