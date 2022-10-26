using Assignment5Gearhart.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5Gearhart.Controllers
{
    public class FuelController : Controller
    {
        private FuelContext context { get; set; }

        public FuelController(FuelContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Display()
        {
            var records = context.FuelRecordModels.OrderBy(f => f.FuelRecordModelId).ToList();


            return View("/Views/Fuel/Display.cshtml", records);
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View("Add", new FuelRecordModel());
        }

        [HttpPost]
        public IActionResult Add(FuelRecordModel record)
        {
            if (ModelState.IsValid)
            {
                if (record.FuelRecordModelId == 0)
                {
                    context.FuelRecordModels.Add(record);
                }
                else
                {
                    context.FuelRecordModels.Update(record);
                }
                context.SaveChanges();
                return RedirectToAction("Display", "Fuel");
            }
            return View(record);
        }
    }
}
