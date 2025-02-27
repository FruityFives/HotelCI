using HotelWebAPI.Models;

namespace HotelWebAPI.Interfaces
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetHotels();
        Room Add(Room newItem);
        Room GetById(int id);
        bool Remove(int id);
    }
}
