using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StreetLight.Models.celled;
using StreetLight.ViewModels.cell;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StreetLight.Controllers
{
    [Authorize(Roles = "管理员")]
    public class CellectController : Controller
    {
        // GET: /<controller>/
        private ICellectRepository _cellectRepository;

        public CellectController(ICellectRepository cellectRepository)
        {
            _cellectRepository = cellectRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var viewmodel = new CellectViewModel()
            {

                Cellects = _cellectRepository.GetAllCellects().ToList()

            };
            return View(viewmodel);
        }

        public IActionResult Delete(int id)
        {

            _cellectRepository.Delete(id);
            //  string filePath = Path.Combine(hostingEnvironment.WebRootPath, "images");
            //  System.IO.File.Delete(filePath);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Creatcellect()
        {

            return View();


        }
        [HttpPost]
        public IActionResult Creatcellect(CreatCellectViewModel model)
        {
            if (ModelState.IsValid)
            {
               
                Cellect newcellect = new Cellect
                {
                    Name = model.Name,
                    Cellectwell=model.Cellectwell,
                    Cellectsour=model.Cellectsour
                };
                _cellectRepository.Addcellect(newcellect);

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
