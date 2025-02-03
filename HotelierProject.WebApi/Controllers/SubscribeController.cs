using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService SubscribeService)
        {
            _subscribeService = SubscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _subscribeService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult SubscribeAdd(Subscribe Subscribe)
        {
            _subscribeService.TInsert(Subscribe);
            return Ok();
        }
        [HttpDelete]
        public IActionResult SubscribeDelete(int id)
        {
            var values = _subscribeService.TGetById(id);
            _subscribeService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult SubscribeUpdate(Subscribe Subscribe)
        {
            _subscribeService.TUpdate(Subscribe);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult SubscribeGet(int id)
        {
            var values = _subscribeService.TGetById(id);
            return Ok(values);
        }
    }
}
