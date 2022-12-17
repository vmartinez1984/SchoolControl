using Microsoft.AspNetCore.Mvc;
using SchoolControl.Core.Dtos;
using SchoolControl.Core.Interfaces;

namespace SchoolControl.Mvc.Controllers
{
    public class GroupCourseController : Base
    {
        public GroupCourseController(ISchoolControlBl schoolControlBl) : base(schoolControlBl)
        {
        }

        // GET: GroupCourseController
        public async Task<ActionResult> Index()
        {
            PagerDto pagerDto;

            pagerDto = await _schoolControlBl.GroupCourse.GetAsync(new PagerDto { });

            return View(pagerDto.List);
        }

        // GET: GroupCourseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GroupCourseController/Create
        public async Task<ActionResult> Create()
        {           
            
            return View();
        }

        // POST: GroupCourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: GroupCourseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GroupCourseController/Edit/5
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

        // GET: GroupCourseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GroupCourseController/Delete/5
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
