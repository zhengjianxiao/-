using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using StreetLight.Models;
using StreetLight.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StreetLight.Controllers
{
    [Authorize]
    public class LightController : Controller
    {

        private ILightRepository _lightRepository;
        private readonly HostingEnvironment hostingEnvironment;

        public LightController(ILightRepository lightRepository ,HostingEnvironment hostingEnvironment)
        {
            _lightRepository = lightRepository;

            this.hostingEnvironment = hostingEnvironment;
           

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var viewmodel = new LightViewModel()
            {
                // FeedBacks = _feedBackRepository.GetAllFeedBacks().ToList(),
                Lights = _lightRepository.GetAllLights().ToList()

            };
            return View(viewmodel);
        }

        public IActionResult Detail(int id)
        {
           
            Light light = _lightRepository.GetLightById(id);
            if (light==null) {

                Response.StatusCode = 404;
                return View("NotFound",id);
            }
            return View(_lightRepository.GetLightById(id));

        }
        
        [Authorize(Roles = "管理员")]
        public IActionResult Delete(int id) {

            _lightRepository.Delete(id);
          
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "管理员")]
        public IActionResult CreatLight() {

            return View();


                }
        [Authorize(Roles = "管理员")]
        [HttpPost]
        public IActionResult CreatLight(CreatLightViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                if (model.Photos!=null&&model.Photos.Count>0) {

                    uniqueFileName= ProcessUpLoadedFile(model);
                }
                Light newLight = new Light
                {
                    Name = model.Name,
                    Iswell = model.Iswell,
                    Iswork = model.Iswork,
                    Lng = model.Lng,
                    Lat = model.Lat,
                    Control = model.Control,
                    Celle = model.Celle,
                    Sens = model.Sens,
                    PhotoPath = uniqueFileName
                };
                _lightRepository.AddLight(newLight);

                return RedirectToAction("Creatsucced");
            }
            return View();

            }
        public IActionResult Creatsucced() {

            return View();
        }
        [Authorize(Roles = "维修人员")]
        
        public IActionResult LightFeedBack() {

            var viewmodel = new LightViewModel()
            {
                // FeedBacks = _feedBackRepository.GetAllFeedBacks().ToList(),
                Lights = _lightRepository.GetAllLights().ToList()

            };
            return View(viewmodel);
        }

    
        [HttpGet]
        public ViewResult Edit(int id) {
            Light light = _lightRepository.GetLightById(id);  
                EditLightViewModel editLightViewModel = new EditLightViewModel
                {
                    Id = light.Id,
                    Name = light.Name,
                    Iswell = light.Iswell,
                    Iswork = light.Iswork,
                    Lng = light.Lng,
                    Lat = light.Lat,
                    Control = light.Control,
                    Celle = light.Celle,
                    Sens = light.Sens,
                    ExistingPhotoPath = light.PhotoPath
                };
                return View(editLightViewModel);  
        }

        [HttpPost]
        public IActionResult Edit(EditLightViewModel model) {
            if (ModelState.IsValid) {

                Light light = _lightRepository.GetLightById(model.Id);
                light.Name = model.Name;
                light.Iswell = model.Iswell;
                light.Iswork = model.Iswork;
                light.Lng = model.Lng;
                light.Lat = model.Lat;
                light.Sens = model.Sens;
                light.Celle = model.Celle;
                light.Control = model.Control;

                if (model.Photos.Count> 0) {
                    if (model.ExistingPhotoPath != null) {
                        string filePath = Path.Combine(hostingEnvironment.WebRootPath, "images", model.ExistingPhotoPath);
                            System.IO.File.Delete(filePath);                    
                    }
                    
                        light.PhotoPath =ProcessUpLoadedFile(model);
                    }

                Light updatelight = _lightRepository.Update(light);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        private string ProcessUpLoadedFile( CreatLightViewModel model) {

            string uniqueFileName = null;


            if (model.Photos.Count > 0)
            {


                foreach (var photo in model.Photos)
                {

                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath,"images");

                    uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;

                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);


                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {

                        photo.CopyTo(fileStream);
                    }

                }
            }

                return uniqueFileName;


            }

        public IActionResult Map() {

            var viewmodel = new LightViewModel()
            {
                // FeedBacks = _feedBackRepository.GetAllFeedBacks().ToList(),
                Lights = _lightRepository.GetAllLights().ToList()

            };
            return View(viewmodel);
        }
    }
}
