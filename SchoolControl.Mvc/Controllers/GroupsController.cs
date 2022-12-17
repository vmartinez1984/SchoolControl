using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolControl.Core.Dtos;
using SchoolControl.Core.Interfaces;
using SchoolControl.Mvc.Models;

namespace SchoolControl.Mvc.Controllers;

public class GroupsController : Base
{
    public GroupsController(ISchoolControlBl schoolControlBl) : base(schoolControlBl)
    {
    }

    public async Task<IActionResult> Index()
    {
        PagerDto pagerDto;

        pagerDto = await _schoolControlBl.Group.GetAsync(new PagerDto { });

        return View(pagerDto.List);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(GroupDtoIn item)
    {
        try
        {
        await _schoolControlBl.Group.AddAsync(item);

            return RedirectToAction(nameof(Index));
        }
        catch (Exception)
        {
            return View(item);            
        }

    }
}