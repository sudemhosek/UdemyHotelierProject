
using Microsoft.AspNetCore.Mvc;
namespace HotelierProject.WebUI.WiewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
