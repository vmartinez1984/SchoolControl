using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolControl.Core.Dtos;
using SchoolControl.Core.Interfaces;

namespace SchoolControl.Mvc.Controllers
{
    public class CoursesController : Base
    {
        public CoursesController(ISchoolControlBl schoolControlBl) : base(schoolControlBl)
        {
        }

        // GET: CoursesController
        public async Task<ActionResult> Index()
        {
            PagerDto pagerDto;

            pagerDto = await _schoolControlBl.Course.GetAsync(new PagerDto { });

            return View(pagerDto.List);
        }

        // GET: CoursesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CoursesController/Create
        public async Task<ActionResult> Create()
        {
            ViewData["ListCurriculums"] = new SelectList(await _schoolControlBl.Curriculum.GetAsync(),"Id","Name");
            return View();
        }

        // POST: CoursesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CourseDtoIn dtoIn)
        {
            try
            {
                await _schoolControlBl.Course.AddAsync(dtoIn);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CoursesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CoursesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CoursesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CoursesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
