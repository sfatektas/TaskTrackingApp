using Microsoft.AspNetCore.Mvc;
using Select.TaskTrackingApp.Bussines.Interfaces;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.UI.ViewComponents
{
    public class TasksComponent : ViewComponent
    {
        readonly IAppUserTaskService _appUserTaskService;

        public TasksComponent(IAppUserTaskService appUserTaskService)
        {
            _appUserTaskService = appUserTaskService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var response = await _appUserTaskService.GetTasksWithUserId(id);
            if (response.ResponseType == Common.Enums.ResponseType.Success)
            {
                return View(response.Data);
            }
            TempData["Message"] = response.Message;           
            return View();
        }
    }
}
