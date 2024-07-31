using Core;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Areas.ClinicArea.Controllers
{
    [Area("ClinicArea")]
    public class ManageDoctorController : Controller
    {
        IDocSpecilityRepo dsrepo;
        IDoctorRepo drepo;
        ISpecilityRepo srepo;
        IAreaRepo arepo;
        IWebHostEnvironment env;
        public ManageDoctorController(IDocSpecilityRepo dsrepo, IDoctorRepo drepo, ISpecilityRepo srepo,IAreaRepo arepo, IWebHostEnvironment env)
        {
            this.dsrepo = dsrepo;
            this.drepo = drepo;
            this.srepo = srepo;
            this.arepo = arepo;
            this.env = env;
        }

        public IActionResult Index()
        {
            return View(this.drepo.GetAll());
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
                this.dsrepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
    }
}
