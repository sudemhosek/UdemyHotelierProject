using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.WiewComponents.Default
{
    public class _TrailerPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    
    }
}
