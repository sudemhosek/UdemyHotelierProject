using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.WiewComponents.Default
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
    
}
