using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepositoryWebApplication1.Interface;
using RepositoryWebApplication1.Models;

namespace RepositoryWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IManufacturerRepo _manufacturer;

        public HomeController(IManufacturerRepo manufacturer)
        {
            _manufacturer = manufacturer;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var manuf = _manufacturer.GetAll();
            return View(manuf);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Manufacturer manuf)
        {
            _manufacturer.InsertData(manuf);
            _manufacturer.Save();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var manuf = _manufacturer.GetById(id);
            return View(manuf);
        }

        [HttpPost]
        public ActionResult Delete(Manufacturer manuf)
        {
            _manufacturer.DeleteData(manuf);
            _manufacturer.Save();
            return RedirectToAction("Index", "Home");
            //return View(manuf);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var manuf = _manufacturer.GetById(id);
            return View(manuf);
        }


        [HttpPost]
        public ActionResult Edit(Manufacturer manuf)
        {
            _manufacturer.UpdateData(manuf);
            _manufacturer.Save();
            //return View(manuf);
            return RedirectToAction("Index", "Home");
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
