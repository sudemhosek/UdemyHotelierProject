using HotelierProject.WebUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelierProject.WebUI.Models.Register
{
	public class RegisterViewModel
	{
		public CreateNewUserDto User { get; set; }
		public List<SelectListItem> WorkLocations { get; set; }
	}
}
