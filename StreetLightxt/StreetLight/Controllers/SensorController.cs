using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StreetLight.Models.sensed;
using StreetLight.ViewModels.sened;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StreetLight.Controllers
{
    [Authorize(Roles = "管理员")]
    public class SensorController : Controller
    {
        // GET: /<controller>/
        private ISensorRepository _sensorRepository;

        public SensorController(ISensorRepository sensorRepository)
        {
            _sensorRepository = sensorRepository;
        }
        // GET: /<controller>/



        public IActionResult Index()
        {
            var viewmodel = new SensorViewModel()
            {

                Sensors = _sensorRepository.GetAllSensors().ToList()

            };
            return View(viewmodel);
        }

        public IActionResult Delete(int id)
        {

            _sensorRepository.Delete(id);
            //  string filePath = Path.Combine(hostingEnvironment.WebRootPath, "images");
            //  System.IO.File.Delete(filePath);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Creatsensor()
        {

            return View();


        }
        [HttpPost]
        public IActionResult Creatsensor(CreatSensorViewModel model)
        {
            if (ModelState.IsValid)
            {

               Sensor newcellect = new Sensor
                {
                    Name = model.Name,
                   Senwell = model.Senwell,
                   Sensour = model.Sensour
               };
                _sensorRepository.Addsensor(newcellect);

                return RedirectToAction("Creatsucced","Light");
            }
            return View();

        }
        public IActionResult Creatsucced()
        {

            return View();
        }
    }
}
