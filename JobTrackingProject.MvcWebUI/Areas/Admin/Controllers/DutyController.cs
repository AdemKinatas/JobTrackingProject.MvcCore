using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.MvcWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DutyController : Controller
    {
        public IActionResult Index()
        {
            TempData["Active"] = "gorev";
            return View();
        }
    }
}
