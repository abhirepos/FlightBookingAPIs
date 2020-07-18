using System;
using System.Collections.Generic;
namespace business_logic{
    public class bookflight : demo{
        
        public static void book(int flightnum, String payment, Dictionary<int,int> seat){
            if(seat[flightnum] == 0){         //no seats available
                Console.WriteLine("Cannot Confirm the booking due to unavailability of seats.");
                return;
            }
            else if(payment=="paid"){         //seats are avaliable and payment status is paid
                Console.WriteLine("Confirmed Status");
                seat[flightnum]--;
            }
            else{
                Console.WriteLine("Status Pending");
            }
        }
        public static void main(String[] args){
            bookflight ob=new bookflight();
            Dictionary<int, int> seat = new Dictionary<int, int>();
            seat=ob.data1();
            
            char c='y';int i=0;
            String[] payment={"paid","denied","failed"};
            while(c!='n'){         //checking if the user wants to book another flight
                if(i==3){
                    i=0;
                }
                Console.Write("Enter the four digit flight number: ");
                int fnum=Convert.ToInt32(Console.ReadLine());
                if(!seat.ContainsKey(fnum)){
                    Console.WriteLine("Invalid flight number");
                }
                else{
                    book(fnum,payment[i],seat);
                    i++;
                }
                Console.Write("Do you want to book another flight? (y/n): ");
                c=Convert.ToChar(Console.ReadLine());
            }
        }
    }
}