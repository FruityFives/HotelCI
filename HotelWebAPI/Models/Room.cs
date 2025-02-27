namespace HotelWebAPI.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public string  Category { get; set; }
        public int Price { get; set; }
    }
}
