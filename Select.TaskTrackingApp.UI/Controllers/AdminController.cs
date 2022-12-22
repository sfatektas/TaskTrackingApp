using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Select.TaskTrackingApp.Bussines.Interfaces;
using Select.TaskTrackingApp.Common.Enums;
using Select.TaskTrackingApp.DataAccess.Migrations;
using Select.TaskTrackingApp.Dtos;
using Select.TaskTrackingApp.Entities;
using Select.TaskTrackingApp.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        readonly IAppUserService _appUserService;
        readonly IAppUserTaskService _appUserTaskService;
        readonly IAppTaskService _appTaskService;
        readonly IMapper _mapper; // for model to dto 
        public AdminController(IAppUserService appUserService, IAppUserTaskService appUserTaskService, IAppTaskService appTaskService, IMapper mapper)
        {
            _appUserService = appUserService;
            _appUserTaskService = appUserTaskService;
            _appTaskService = appTaskService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> UserManagment()
        {
            var response = await _appUserService.GetIncluded();
            if (response.ResponseType == ResponseType.Success)
            {
                return View(response.Data.Where(x => x.AppUserRoles.All(x => x.AppRoleId == (int)RoleType.User)).ToList());
            }
            ViewBag.Message = "İlgili Data Bulunamadı.";
            return View();
        }
        [HttpGet]
        [Route("Admin/AddTask")]
        public async Task<IActionResult> TaskManagment()
        {
            var response = await _appTaskService.GetPriortiries();
            if (response.ResponseType == ResponseType.Success)
            {
                var model = new AppTaskCreateModel()
                {
                    PriortrySelectList = new SelectList(response.Data, "Id", "Defination"),
                    EndDateTime = DateTime.UtcNow

                };
                return View(model);
            }
            ViewBag.Message = "Something went wrong :(";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTask(AppTaskCreateModel model)
        {
            if (ModelState.IsValid)
            {   
                var response = await _appTaskService.CreateAsync(_mapper.Map<AppTaskCreateDto>(model));
                if (response.ResponseType == ResponseType.Success)
                    return RedirectToAction("TaskStatues");
                else
                    return View();
            }
            else
                return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {  

            var response = await _appTaskService.GetByIdAsync(id);
            if (response.ResponseType == ResponseType.Success)
            {
                var priortryResponse = await _appTaskService.GetPriortiries();
                var model = _mapper.Map<AppTaskUpdateModel>(response.Data);

                model.PriortrySelectList = new SelectList(priortryResponse.Data, "Id", "Defination", response.Data.PriortryId);

                return View(model);
            }
            //else 
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            var response = await _appTaskService.GetByIdAsync(id);
            if (response.ResponseType == ResponseType.Success)
            {
                var responseRemove = await _appTaskService.Remove(response.Data); // RemoveAsync
                if (responseRemove.ResponseType != ResponseType.Success)
                {
                    ViewBag.Message = responseRemove.Message;
                }
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Message = "Bulunamadı"+response.Message;
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Update(AppTaskUpdateModel model)
        {
            if (ModelState.IsValid)
            {
                var updateModel = _mapper.Map<AppTaskUpdateDto>(model);
                var response = await _appTaskService.UpdateAsync(updateModel);
                if (response.ResponseType == ResponseType.Success)
                {
                    ViewBag.Message = $"Başarı ile güncellendi.";
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.Message = $"Something went wrong : {response.Message}";
            }
            return View(model);
        }
        public async Task<IActionResult> TaskStatues()
        {
            var response = await _appUserTaskService.GetIncluded();
            if (response.ResponseType == ResponseType.Success)
            {
                return View(response.Data);
            }
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> TaskDetail(int id)
        {
            var response = await _appUserTaskService.GetIncluded(id);
            if (response.ResponseType == ResponseType.Success)
            {
                return View(response.Data);
            }

            return NotFound();
        }

    }
}
