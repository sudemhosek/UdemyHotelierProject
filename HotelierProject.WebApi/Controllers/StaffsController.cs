using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {private readonly IStaffsService _staffsService;

        public StaffsController(IStaffsService staffsService)
        {
            _staffsService = staffsService;
        }

        [HttpGet]
        public IActionResult StaffsList()
        { 
            var values =_staffsService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult StaffsAdd(Staffs staffs)
        {
            _staffsService.TInsert(staffs);
            return Ok(); 
        }
        [HttpDelete]
        public IActionResult StaffsDelete(int id) 
        {
            var values =_staffsService.TGetById(id);
            _staffsService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult StaffsUpdate(Staffs staffs) 
        {
            _staffsService.TUpdate(staffs);
            return Ok();
            
        }

        [HttpGet("{id}")]
        public IActionResult StaffsGet(int id)
        {
            var values = _staffsService.TGetById(id);
            return Ok(values);
        }
        [HttpGet("Last4Staff")]
        public IActionResult Last4Staff()
        {
            var values = _staffsService.TLast4Staff();
            return Ok(values);
        }
    }
}
