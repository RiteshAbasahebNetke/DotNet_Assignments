using Core;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Identity.Client;

namespace Web.Areas.ClinicArea.Controllers
{
    [Area("ClinicArea")]
    public class ManageDoctorController : Controller
    {
        IDoctorRepo drepo;
        IAreaRepo arepo;
        IWebHostEnvironment env;
        public ManageDoctorController(IDoctorRepo drepo,IAreaRepo arepo, IWebHostEnvironment env)
        {
            this.drepo = drepo;
            this.arepo = arepo;
            this.env = env;
        }

        public IActionResult Index()
        {
            var id = Convert.ToInt64(HttpContext.Session.GetString("ClinicID"));
            return View(this.drepo.GetByDID(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(DocSpecilityVM rec)
        {
            ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
            if (ModelState.IsValid)
            {
                if (rec.DoctorPhoto != null)
                {
                    if (rec.DoctorPhoto.Length > 0)
                    {
                        string filename = rec.DoctorPhoto.FileName;
                        string folderpath = Path.Combine(env.WebRootPath, "DoctorPhotos");
                        string actualfilepath = Path.Combine(folderpath, filename);
                        FileStream fs = new FileStream(actualfilepath, FileMode.Create);
                        rec.DoctorPhoto.CopyTo(fs);

                        rec.PhotoPath = Path.Combine("\\DoctorPhotos", filename);

                    }
                }
                
                this.drepo.Add(rec);
                return RedirectToAction("Index");

            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.drepo.GetByDocID(id);
            ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(DocSpecilityVM rec)
        {
            ViewBag.AreaID = new SelectList(this.arepo.GetAll(), "AreaID", "AreaName");
            if (ModelState.IsValid)
            {
                if (rec.DoctorPhoto != null)
                {
                    if (rec.DoctorPhoto.Length > 0)
                    {
                        string filename = rec.DoctorPhoto.FileName;
                        string folderpath = Path.Combine(env.WebRootPath, "DoctorPhotos");
                        string actualfilepath = Path.Combine(folderpath, filename);
                        FileStream fs = new FileStream(actualfilepath, FileMode.Create);
                        rec.DoctorPhoto.CopyTo(fs);

                        rec.PhotoPath = Path.Combine("\\DoctorPhotos", filename);

                    }
                }
                this.drepo.EditDoc(rec);
                return RedirectToAction("Index");

            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.drepo.DeleteDoc(id);
            return RedirectToAction("Index");
        }

        //[HttpGet]
        //public IActionResult Details(Int64 id)
        //{
        //    this.drepo.(id);
        //    return RedirectToAction("Index");
        //}
        
    }
}
