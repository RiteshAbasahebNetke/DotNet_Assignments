using Curd_Using_Repo.Models;
using Curd_Using_Repo.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace Curd_Using_Repo.Controllers
{
    public class HomeController : Controller
    {
        ICourseRepo courseRepo;
        ICourseCategoryRepo courseCategoryRepo;
        public HomeController(ICourseRepo courseRepo, ICourseCategoryRepo courseCategoryRepo)
        {
            this.courseRepo = courseRepo;
            this.courseCategoryRepo = courseCategoryRepo;
        }
        public IActionResult Index()
        {
            return View(this.courseRepo.GetAll());
        }
        [HttpPost]
        public IActionResult SearchByCat(Int64 CatID)
        {
            ViewBag.CourseCategories = new SelectList(this.courseCategoryRepo.GetAllCategories(), "CourseCategoryID", "CourseCategoryName");
            if (CatID == 0)
            {
                return View("Index", this.courseRepo.GetAll());
            }
            else
            {
                return View("Index", this.courseRepo.GetCategoryID(CatID));
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Courses = new SelectList(this.courseCategoryRepo.GetAllCategories(), "CourseCategoryID", "CourseCategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course rec)
        {
            this.courseRepo.Add(rec);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.courseRepo.GetById(id);
            ViewBag.CourseCategories = new SelectList(this.courseCategoryRepo.GetAllCategories(), "CourseCategoryID","CourseCategoryName");
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Course rec)
        {
            this.courseRepo.Edit(rec);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Int64 id)
        {
            this.courseRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
