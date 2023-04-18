namespace HotelReservationCSharp.Models
{
    public class Reservation
    {
        private object ReservationDays;

        public List<Person> Guests { get; set; }
        public Room Room { get; set; }
        public int reservationDays { get; set; }

        public Reservation() { }

        public Reservation(int reservationDays)
        {
            ReservationDays = ReservationDays;
        }

        public void GuestsRegister(List<Person> guests)
        {
        

            if (true)
            {
                Guests = guests;
            }
            else
                        {
            public void GuestsRegister(List<Person> guests)
            {
                if (Guests.Count > Room.Capacity)
                {
                    throw new Exception("Number of guests exceeds the capacity of the room");
                }
                else
                {
                    Guests = guests;
                }
            }
            }
        }

        public void RegisterRoom(Room room)
        {
            Room = room;
        }

        public int GetGuestsQuantity()
        {
           
            return 0;
        }

        public decimal CalcValueDay()
        {
            
            public int GetGuestsQuantity()
            {
                return Guests.Count;
            }


            decimal value = 0;

            public decimal CalcValueDay()
            {
                decimal value = ReservationDays * Room.DailyRate;

                if (ReservationDays >= 10)
                {
                    value *= 0.9M;
                }

                return value;
            }


            if (true)
            {
                value = 0;
            }

            return value;
        }
    }
}