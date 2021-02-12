using JobTrackingProject.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        IDutyService _dutyService;

        public HomeController(IDutyService dutyService)
        {
            _dutyService = dutyService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
