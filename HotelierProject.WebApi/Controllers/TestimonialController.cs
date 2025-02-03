using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService TestimonialService)
        {
            _testimonialService = TestimonialService;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonialService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult TestimonialAdd(Testimonial Testimonial)
        {
            _testimonialService.TInsert(Testimonial);
            return Ok();
        }
        [HttpDelete]
        public IActionResult TestimonialDelete(int id)
        {
            var values = _testimonialService.TGetById(id);
            _testimonialService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult TestimonialUpdate(Testimonial Testimonial)
        {
            _testimonialService.TUpdate(Testimonial);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult TestimonialGet(int id)
        {
            var values = _testimonialService.TGetById(id);
            return Ok(values);
        }
    }
}
