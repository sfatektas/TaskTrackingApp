using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Select.TaskTrackingApp.Bussines.Interfaces;
using Select.TaskTrackingApp.Common.Enums;
using Select.TaskTrackingApp.DataAccess.Interfaces;
using Select.TaskTrackingApp.Dtos;
using Select.TaskTrackingApp.Dtos.AppUserTaskDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.UI.Controllers
{
    [Authorize(Roles = "User")]
    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAppUserTaskService _appUserTaskService;
        private readonly IAppTaskService _appTaskService;

        public UserController(IAppUserTaskService appUserTaskService, IAppTaskService appTaskService, IMapper mapper)
        {
            _appUserTaskService = appUserTaskService;
            _appTaskService = appTaskService;
            _mapper = mapper;
        }

        public IActionResult TakeTask()
        {
            return View();
        }
        public async Task<IActionResult> AcceptTask(int taskId, string userName)
        {
            var taskResponse = await _appTaskService.GetByIdAsync(taskId);
            var result = await _appUserTaskService.CreateAppUserTask(taskId, userName);
            if (result.ResponseType == ResponseType.Success)
            {
                await _appTaskService.Remove(taskResponse.Data);
            }
            return RedirectToAction("MyTasks");
        }
        public IActionResult MyTasks()
        {
            return View();
        }
        public IActionResult ViewDetail(int id)
        {
            return View();
        }
        public async Task<IActionResult> ComplateTask(int id)
        {
            // to do queryable yapıp defination propertyleri doldur , jquery çalışıyor mu kontrol et 
            var response = await _appUserTaskService.GetByIdAsync(id);
            if (response.ResponseType == ResponseType.Success)
            {
                return View(_mapper.Map<AppUserTaskUpdateDto>(response.Data));
            }
            else
                return NotFound();
        }
        public IActionResult ChangePassword()
        {
            return View();
        }
    }
}
