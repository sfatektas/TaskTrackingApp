using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Select.TaskTrackingApp.Bussines.Interfaces;
using Select.TaskTrackingApp.Bussines.Services;
using Select.TaskTrackingApp.DataAccess.Context;
using Select.TaskTrackingApp.UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IAppTaskService _appTaskService;

        public HomeController(IAppUserService appUserService, IAppTaskService appTaskService)
        {
            _appUserService = appUserService;
            _appTaskService = appTaskService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _appTaskService.GetAllAsync();
            
            return View(response.Data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
