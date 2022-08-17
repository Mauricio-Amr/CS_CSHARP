using System;
using exececao2.Entities;
using exececao2.Entities.Exceptions;

namespace exececao2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Room Number");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-oAut date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation();
                Console.WriteLine("Reservertaion: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDate(checkIn, checkOut);
                Console.WriteLine("Resservation: " + reservation);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format " + e.Message);
            }
            catch(DomainExeception e)
            {
                Console.WriteLine("Error in reservation " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error" + e.Message);
            }
        }
    }
}
