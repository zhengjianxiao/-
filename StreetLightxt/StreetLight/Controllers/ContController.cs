using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StreetLight.Models.controled;
using StreetLight.ViewModels.cont;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StreetLight.Controllers
{
    [Authorize(Roles = "管理员")]
    public class ContController : Controller
    {
        // GET: /<controller>/
        private IConVectorRepository _conVectorRepository;

        public ContController(IConVectorRepository conVectorRepository)
        {
            _conVectorRepository = conVectorRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var viewmodel = new ConvectorViewModel()
            {

                Convectors = _conVectorRepository.GetAllConVectors().ToList()

            };
            return View(viewmodel);
        }

        public IActionResult Delete(int id)
        {

           _conVectorRepository.Delete(id);
            //  string filePath = Path.Combine(hostingEnvironment.WebRootPath, "images");
            //  System.IO.File.Delete(filePath);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Creatcontro()
        {

            return View();


        }
        [HttpPost]
        public IActionResult Creatcontro(CreatControViewModel model)
        {
            if (ModelState.IsValid)
            {

                ConVector newcellect = new ConVector
                {
                    Name = model.Name,
                    Conwell = model.Conwell,
                    Consour = model.Consour
                };
               _conVectorRepository.Addcontro(newcellect);

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
