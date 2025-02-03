using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.WiewComponents.Default
{
    public class _ScriptsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    
    }
}
