using HotelierProject.WebUI.Dtos.ContactDto;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelierProject.WebUI.Models.SendMessage
{
    public class SendMessageViewModel
    {
        public CreateContactDto Contact { get; set; } // Form verilerini tutacak DTO
        public IEnumerable<SelectListItem> MessageCategories { get; set; }
    }
}
