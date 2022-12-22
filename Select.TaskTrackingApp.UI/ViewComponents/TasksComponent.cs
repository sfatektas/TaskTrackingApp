﻿using Microsoft.AspNetCore.Mvc;
using Select.TaskTrackingApp.Bussines.Interfaces;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.UI.ViewComponents
{
    public class TasksComponent : ViewComponent
    {
        readonly IAppTaskService _appTaskService;

        public TasksComponent(IAppTaskService appTaskService)
        {
            _appTaskService = appTaskService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _appTaskService.GetAllAsync(x=>x.IsActive==true);
            if (response.ResponseType == Common.Enums.ResponseType.Success)
            {
                return View(response.Data);
            }
            TempData["Message"] = response.Message;           
            return View();
        }
    }
}
