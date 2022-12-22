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
        private readonly IAppTaskService _appTaskService;

        public HomeController(IAppUserService appUserService, IAppTaskService appTaskService)
        {
            _appTaskService = appTaskService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _appTaskService.GetIncluded();
            
            return View(response.Data.Where(x => x.IsActive==true).ToList());
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
