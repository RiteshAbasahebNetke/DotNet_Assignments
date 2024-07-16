using CURD_Repo_6.Models;
using CURD_Repo_6.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CURD_Repo_6.Controllers
{
    public class HomeController : Controller
    {
        IBookRepo brepo;
        ISubjectRepo srepo;
        public HomeController(IBookRepo brepo, ISubjectRepo srepo)
        {
            this.brepo = brepo;
            this.srepo = srepo;
        }
        public IActionResult Index()
        {
            ViewBag.SubjectID = new SelectList(this.srepo.GetAllSubjects(), "SubjectID", "SubjectName");
            return View(this.brepo.GetAll());
        }

        [HttpPost]
        public IActionResult SearchBySub(Int64 SID)
        {
            ViewBag.SubjectID = new SelectList(this.srepo.GetAllSubjects(), "SubjectID", "SubjectName");
            if (SID == 0)
            {
                return View("Index", this.brepo.GetAll());
            }
            else
            {
                var v = this.brepo.GetAllSub(SID);
                return View("Index", v.ToList());
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.SubjectID = new SelectList(this.srepo.GetAllSubjects(), "SubjectID", "SubjectName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book rec)
        {
            if (ModelState.IsValid)
            {
                this.brepo.Add(rec);
                return RedirectToAction("Index");
            }
            ViewBag.SubjectID = new SelectList(this.srepo.GetAllSubjects(), "SubjectID", "SubjectName");
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.SubjectID = new SelectList(this.srepo.GetAllSubjects(), "SubjectID", "SubjectName");
            var rec = this.brepo.GetByID(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Book rec)
        {
            if (ModelState.IsValid)
            {
                this.brepo.Edit(rec);
                return RedirectToAction("Index");
            }
            ViewBag.SubjectID = new SelectList(this.srepo.GetAllSubjects(), "SubjectID", "SubjectName");
            return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.brepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
