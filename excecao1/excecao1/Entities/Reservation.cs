using System;


namespace excecao1.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            Checkin = checkin;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn , DateTime checkOut)
        {
            Checkin = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Romm "
                +RoomNumber
                +", check - in: "
                +Checkin.ToString("dd/MM/yyyy")
                +", check - out "
                +CheckOut.ToString("dd/MM/yyyy")
                +", "
                +Duration()
                +" nigth";
        }
    }
}
