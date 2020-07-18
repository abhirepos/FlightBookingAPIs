using System;
using System.Collections.Generic;
namespace business_logic{
    public class cancelBooking : demo{
        static void cancel(int id,Dictionary<int,string> bookings,Dictionary<int, int> seats,Dictionary<int, int> flightbook){
            if(bookings[id] == "cancelled"){
                Console.WriteLine("Booking is already cancelled");
            }
            else if(bookings[id] == "pending" || bookings[id] =="confirmed"){
                Console.WriteLine("cancelled");
                bookings[id]="cancelled";   // changed the status from paid to cancelled
                int flightnumbr=flightbook[id];     //getting the flight number
                seats[flightnumbr]++;    //increamenting the seats
            }
            else{
                Console.WriteLine("Invalid Booking number");
            }
        }
        public static void main(String[] args){
            cancelBooking ob=new cancelBooking();
            Dictionary<int, int> seats = new Dictionary<int, int>();
            seats=ob.data1();
            Dictionary<int, String> bookings = new Dictionary<int, String>();
            bookings=ob.data2();
            Dictionary<int, int> flightbook = new Dictionary<int, int>();
            flightbook=ob.data3();
            
            char c='y';
            while(c!='n'){                           // check if the user wants to cancel one more flight
                Console.Write("Enter the three digit booking id: ");
                int id=Convert.ToInt32(Console.ReadLine());
                if(!bookings.ContainsKey(id)){
                    Console.WriteLine("Invalid Booking number");
                }
                else{
                    cancel(id,bookings,seats,flightbook);
                }
                Console.Write("Do you want to cancel one more flight? (y/n): ");
                c=Convert.ToChar(Console.ReadLine());
            }
        }
    }
}