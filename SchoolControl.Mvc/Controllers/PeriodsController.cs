using Microsoft.AspNetCore.Mvc;
using SchoolControl.Core.Dtos;
using SchoolControl.Core.Interfaces;

namespace SchoolControl.Mvc.Controllers;

public class PeriodsController: Controller
{
    private readonly ISchoolControlBl _businessLayer;

    public PeriodsController(ISchoolControlBl businessLayer)
    {
        _businessLayer = businessLayer;
    }

    public async Task<IActionResult> Index()
    {
        List<PeriodDto> list;

        list = await _businessLayer.Period.GetAsync();

        return View(list);
    }

    public async Task<IActionResult> Create()
    {

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(PeriodDto periodDto)
    {
        int id;

        id = await _businessLayer.Period.AddAsync(periodDto);

        return RedirectToAction(nameof(Index));
    }
}