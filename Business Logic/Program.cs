using System;

namespace Business_Logic
{
     public class BookFlight
    {
        public static void Main(string[] args)
        {
            string[] FlightNumbers = {"F001","F002","F003","F004","F005","F006","F007","F008","F009","F010"};
            string[] CustomerIDs = {"CI012","CI045","CI078","CI056","CI007"};
            int[] Availability = {152,46,75,345,89,0,2,24,0,200};
            Console.Write("Enter the CustomerID - ");
            string CustomerID = Console.ReadLine().ToUpper();
            Console.Write("Enter the payment status - ");
            string PaymentStat = Console.ReadLine().ToLower();
            Console.Write("Enter the flight you want to book -  ");
            string flight = Console.ReadLine().ToUpper();
            Console.Write("Enter the no. of seats you want to book - ");
            int seats = Convert.ToInt32(Console.ReadLine());
            if (seats>Availability[Array.IndexOf(FlightNumbers,flight)])
                Console.WriteLine("Cannot confirm the booking due to unavailability of seats");
            else
            {
                if (PaymentStat.Equals("paid"))
                {
                    Console.WriteLine("The booking has been confirmed");
                    Availability[Array.IndexOf(FlightNumbers,flight)] -= seats;
                }
                else if (PaymentStat.Equals("deniedbybank") || PaymentStat.Equals("failed"))
                    Console.WriteLine("The booking is pending");
                else if (PaymentStat.Equals("cancelledbyuser"))
                    Console.WriteLine("The booking has been cancelled");
                else 
                    Console.WriteLine("Invalid Payment status");
            }
        }
    }
}
