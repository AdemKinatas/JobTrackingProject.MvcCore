using JobTrackingProject.Business.Abstract;
using JobTrackingProject.Entities.Concrete;
using JobTrackingProject.MvcWebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.MvcWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UrgencyController : Controller
    {
        IUrgencyService _urgencyService;

        public UrgencyController(IUrgencyService urgencyService)
        {
            _urgencyService = urgencyService;
        }

        public IActionResult Index()
        {
            TempData["Active"] = "aciliyet";

            List<Urgency> urgencies= _urgencyService.GetAll();

            List<UrgencyListViewModel> model = new List<UrgencyListViewModel>();

            foreach (var urgency in urgencies)
            {
                UrgencyListViewModel viewModel = new UrgencyListViewModel();
                viewModel.Id = urgency.Id;
                viewModel.Description = urgency.Description;
                model.Add(viewModel);
            }

            return View(model);
        }

        public IActionResult AddUrgency()
        {
            TempData["Active"] = "aciliyet";

            var model = new UrgencyAddViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddUrgency(UrgencyAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _urgencyService.Add(new Urgency { Description = model.Description });

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult UpdateUrgency(int id)
        {
            TempData["Active"] = "aciliyet";

            var urgency = _urgencyService.GetByFilter(u=>u.Id==id);
            UrgencyUpdateViewModel model = new UrgencyUpdateViewModel();
            model.Id = urgency.Id;
            model.Description = urgency.Description;

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateUrgency(UrgencyUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                _urgencyService.Update(new Urgency { Id = model.Id, Description = model.Description });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
