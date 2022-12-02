using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult UserManagment()
        {
            return View();
        }

        public IActionResult TaskManagment()
        {
            return View();
        }

        public IActionResult TaskStatues()
        {
            return View();
        }
        public IActionResult TaskDetail()
        {
            return View();
        }
    }
}
