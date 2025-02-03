using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService RoomService)
        {
            _roomService = RoomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult RoomAdd(Room Room)
        {
            _roomService.TInsert(Room);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult RoomDelete(int id)
        {
            var values = _roomService.TGetById(id);
            _roomService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult RoomUpdate(Room Room)
        {
            _roomService.TUpdate(Room);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult RoomGet(int id)
        {
            var values = _roomService.TGetById(id);
            return Ok(values);
        }
    }
}
