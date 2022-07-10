using System;
using excecao1.Entities;

namespace excecao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Room number ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Check-in date (dd/MM/YYYY) : ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-out date (dd/MM/YYYY) : ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());


            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation : Check - out date must be after ...");
            }
            else {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation : "+ reservation);

                Console.WriteLine();
                Console.WriteLine("Enter date to update the reservation: ");
                Console.WriteLine("Check-in date (dd/MM/yyyy) : ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check - out date (dd/MM/yyyy) : ");
                checkOut = DateTime.Parse(Console.ReadLine());


            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                Console.WriteLine("Error in reservation : Reservation dates ");
            }
            else if (checkOut <= checkIn)
            {
           
                Console.WriteLine("Erro in reservation : Check-out date must be after check-in date ");
            }
            else
            {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation : " + reservation);
                
            }
            }
        }
    }
}
