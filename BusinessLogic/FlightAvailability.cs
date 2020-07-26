using System;
using System.Collections.Generic;
namespace FlightBookingAPIs.BusinessLogic{

public interface IFlightAvailability{
    public Boolean checking (int FlightNo);

}
    public class FlightAvailability:IFlightAvailability{
        MockData.UserData ob = new MockData.UserData();
        public Boolean checking (int FlightNo)
        {
            
            Dictionary<int,int> available = ob.FlightSeatMock();
            if(available.ContainsKey(FlightNo)==false)
            return false;
            else
            {
                return true;
            }
        }
        public int results(int FlightNo)

        {
            if (checking(FlightNo)==false)
            return -1;
            else
            {
                Dictionary<int,int> available = ob.FlightSeatMock();
                return available[FlightNo];

            }
        }
    }
}
