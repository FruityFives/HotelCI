using HotelWebAPI.Models;

namespace HotelWebAPI.Interfaces
{
    public interface IHotelRepository
    {
        IEnumerable<Hotel> GetHotels();
        Hotel Add(Hotel newItem);
        Hotel GetById(int id);
        bool Remove(int id);
    }
}
