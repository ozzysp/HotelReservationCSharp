namespace HotelReservationCSharp.Models
{
    public class Room
    {
        public Room() { }
        

        public Room(string roomType, int capacity, decimal valueDay)
        {
            RoomType = roomType;
            Capacity = capacity;
            ValueDay = valueDay;
        }

        public string RoomType { get; set; }
        public int Capacity { get; set; }
        public decimal ValueDay { get; set; }
    }
}