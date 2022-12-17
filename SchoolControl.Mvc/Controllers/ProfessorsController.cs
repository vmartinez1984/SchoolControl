using Microsoft.AspNetCore.Mvc;
using SchoolControl.Core.Dtos;
using SchoolControl.Core.Interfaces;

namespace SchoolControl.Mvc.Controllers
{
    public class ProfessorsController : Base
    {
        public ProfessorsController(ISchoolControlBl schoolControlBl) : base(schoolControlBl)
        {
        }

        // GET: ProfessorsController
        public async Task<ActionResult> Index()
        {
            PagerDto pagerDto;

            pagerDto = await _schoolControlBl.Professor.GetAsync(new PagerDto { });

            return View(pagerDto.List);
        }

        // GET: ProfessorsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProfessorsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfessorsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProfessorDtoIn item)
        {
            try
            {
                await _schoolControlBl.Professor.AddAsync(item);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfessorsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProfessorsController/Edit/5
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

        // GET: ProfessorsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProfessorsController/Delete/5
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
