using Microsoft.AspNetCore.Mvc;
using Select.TaskTrackingApp.UI.Models;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.UI.ViewComponents
{
    public class TaskFileCommentUploadComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            return View(new AppUserTaskUpdateModel() { AppUserTaskId = id});
        }
    }
}
