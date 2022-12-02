using Microsoft.AspNetCore.Mvc;
using Select.TaskTrackingApp.UI.Models;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.UI.ViewComponents
{
    public class TaskFileCommentUploadComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new AppUserTaskUpdateModel());
        }
    }
}
