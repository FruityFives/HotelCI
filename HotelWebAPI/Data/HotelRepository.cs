using HotelWebAPI.Interfaces;
using HotelWebAPI.Models;

namespace HotelWebAPI.Data
{
    public class HotelRepository:IHotelRepository
    {
        private readonly List<Hotel> _hotels;
        private readonly List<Room> _rooms;
        public HotelRepository()
        {
            _hotels = new List<Hotel>()
            {
                new Hotel
                { 
                    HotelId = 1, Name="Hilton"
                     
                },
                new  Hotel
                {
                    HotelId= 2, Name="Siphon"
                }
                ,
                new Hotel
                {
                    HotelId = 3, Name="Sheraton"

                },
                new  Hotel
                {
                    HotelId= 4, Name="ABC"
                }
            };

        }
        public IEnumerable<Hotel> GetHotels() => _hotels;

        public Hotel Add(Hotel newHotel)
        {
            _hotels.Add(newHotel);
            return newHotel;
        }

        public Hotel GetById(int id)
        {
            return _hotels.Where(a => a.HotelId == id).FirstOrDefault();
        }

        public bool Remove(int id)
        {
            var existing = _hotels.First(a => a.HotelId == id);
            if (existing != null)
            {
                _hotels.Remove(existing);
                return true;
            }
            else return false;
        }

    }
}
