using JobTrackingProject.Business.Abstract;
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
        IDutyService _dutyService;

        public DutyController(IDutyService dutyService)
        {
            _dutyService = dutyService;
        }

        public IActionResult Index()
        {
            TempData["Active"] = "gorev";
            _dutyService.GetAll();
            return View();
        }
    }
}
