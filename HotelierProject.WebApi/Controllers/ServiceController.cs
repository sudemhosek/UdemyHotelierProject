using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService ServiceService)
        {
            _serviceService = ServiceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _serviceService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult ServiceAdd(Service Service)
        {
            _serviceService.TInsert(Service);
            return Ok();
        }
        [HttpDelete]
        public IActionResult ServiceDelete(int id)
        {
            var values = _serviceService.TGetById(id);
            _serviceService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult ServiceUpdate(Service Service)
        {
            _serviceService.TUpdate(Service);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult ServiceGet(int id)
        {
            var values = _serviceService.TGetById(id);
            return Ok(values);
        }
    }
}
