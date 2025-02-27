using HotelWebAPI.Data;
using HotelWebAPI.Interfaces;
using HotelWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelsController : Controller
    {
        
       
        private readonly IHotelRepository _repository;

        public HotelsController( IHotelRepository repository)
        {
           
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var items = _repository.GetHotels();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = _repository.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Hotel  value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var hotel = _repository.Add(value);
            return CreatedAtAction("Get", new { id = hotel.HotelId },  hotel);
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var existingItem = _repository.GetById(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            _repository.Remove(id);
            return NoContent();
        }
    }
}
