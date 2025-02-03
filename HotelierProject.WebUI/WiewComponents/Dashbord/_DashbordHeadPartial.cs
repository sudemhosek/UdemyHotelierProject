using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.WiewComponents.Dashbord
{
    public class _DashbordHeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    
    }
}
