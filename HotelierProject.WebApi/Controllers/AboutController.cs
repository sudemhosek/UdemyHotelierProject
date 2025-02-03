using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutservice;

        public AboutController(IAboutService aboutservice)
        {
            _aboutservice = aboutservice;
        }


        [HttpGet]
        public IActionResult Aboutlist()
        {
            var values = _aboutservice.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AboutAdd(About about)
        {
            _aboutservice.TInsert(about);
            return Ok();
        }
        [HttpDelete]
        public IActionResult AboutDelete(int id)
        {
            var values = _aboutservice.TGetById(id);
            _aboutservice.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult AboutUpdate(About about)
        {
            _aboutservice.TUpdate(about);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult AboutGet(int id)
        {
            var values = _aboutservice.TGetById(id);
            return Ok(values);
        }
    }

   
}
