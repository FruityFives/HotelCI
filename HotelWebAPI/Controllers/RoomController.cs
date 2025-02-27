using Microsoft.AspNetCore.Mvc;

namespace HotelWebAPI.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
