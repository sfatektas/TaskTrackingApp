using Microsoft.AspNetCore.Mvc;

namespace Select.TaskTrackingApp.UI.ViewComponents
{
    public class UserAddComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
