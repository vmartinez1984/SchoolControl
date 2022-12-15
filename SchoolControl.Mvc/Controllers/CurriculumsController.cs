using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolControl.Core.Dtos;
using SchoolControl.Core.Interfaces;

namespace SchoolControl.Mvc.Controllers
{
    public class CurriculumsController : Base
    {
        public CurriculumsController(ISchoolControlBl schoolControlBl) : base(schoolControlBl)
        {
        }


        // GET: CurriculumsController
        public async Task<ActionResult> Index()
        {
            List<CurriculumDto> list;

            list = await _schoolControlBl.Curriculum.GetAsync();

            return View(list);
        }

        // GET: CurriculumsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CurriculumsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CurriculumsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CurriculumDtoIn curriculumDtoIn)
        {
            try
            {
                await _schoolControlBl.Curriculum.AddAsync(curriculumDtoIn);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CurriculumsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CurriculumsController/Edit/5
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

        // GET: CurriculumsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CurriculumsController/Delete/5
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
