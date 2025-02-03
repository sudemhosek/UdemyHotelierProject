using HotelierProject.EntityLayer.Concrete;
using HotelierProject.WebUI.Dtos.MessageCategoryDto;
using HotelierProject.WebUI.Dtos.RegisterDto;
using HotelierProject.WebUI.Dtos.WorkLocationDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace HotelierProject.WebUI.Controllers
{
    [AllowAnonymous]
	public class RegisterController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
        private readonly IHttpClientFactory _httpClientFactory;
        public RegisterController(UserManager<AppUser> userManager, IHttpClientFactory httpClientFactory)
        {
            _userManager = userManager;
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
		public async Task< IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5277/api/WorkLocation");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultWorkLocationDto>>(jsonData);

            return View();

        }

		[HttpPost]
		public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            var appUser = new AppUser()
            {
                Name = createNewUserDto.Name,
                Email = createNewUserDto.Mail,
                Surname = createNewUserDto.Surname,
                UserName = createNewUserDto.Username,
                WorkLocationID = createNewUserDto.WorkLocationID,
                Gender = createNewUserDto.Gender,
                ImageUrl = "https://w7.pngwing.com/pngs/741/68/png-transparent-user-computer-icons-user-miscellaneous-cdr-rectangle-thumbnail.png",
                Country = "Türkiye",
                WorkDepartment = createNewUserDto.WorkDepartment,  // Burada WorkDepartment'ı alıyoruz
                City = createNewUserDto.City,  // Burada City'yi alıyoruz
             

            };

            var result = await _userManager.CreateAsync(appUser, createNewUserDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }
	}
	}

